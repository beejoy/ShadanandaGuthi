using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShadanandaGuthiLibrary.DataAccess;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthi
{
    public partial class TenantRegisterAndTransferForm : Form
    {
        public TenantRegisterAndTransferForm()
        {
            InitializeComponent();
        }
        
        private void TenantRegisterAndTransferForm_Load(object sender, EventArgs e)
        {
            // Set tooltips for various controls
            ToolTipMain.SetToolTip(ComboBoxLocation, "जग्गा भएको स्थान छान्नुहोस्");
            ToolTipMain.SetToolTip(ComboBoxLand, "जग्गा कित्ता छान्नुहोस्");
            ToolTipMain.SetToolTip(ComboBoxNewTenant, "नयाँ मोही छान्नुहोस्");
            ToolTipMain.SetToolTip(TextBoxLeaseFrom, "भोग चलन सुरु गरेको मिति जस्तै: २०७५-११-२२");
        }

        private void TenantRegisterAndTransferForm_Activated(object sender, EventArgs e)
        {
            PopulateLocations();
        }

        private void ComboBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            LandDA landDA = new LandDA();
            Location location = (Location)ComboBoxLocation.SelectedItem;
            List<Land> lands = landDA.GetLandsByLocation(location);
            try
            {
                ComboBoxLand.DataSource = lands;
                ComboBoxLand.DisplayMember = "LandInfo";
                ComboBoxLand.ValueMember = "LandID";
            }
            catch (Exception)
            {
                MessageForm messageForm = new MessageForm();
                messageForm.MessageText = "ओहो! केही आन्तरिक त्रुटीको कारण जग्गा कित्ताको विवरण लोड गर्न सकिएन।";
                messageForm.ShowDialog();
            }
        }

        private void ComboBoxLand_SelectedIndexChanged(object sender, EventArgs e)
        {
            // List only those tenants who are currently in lease contract
            // not the ones who have transfered their ownership already.

            LeaseDA leaseDA = new LeaseDA();
            Land selectedLand = (Land)ComboBoxLand.SelectedItem;
            List<Tenant> currentTenant = leaseDA.GetCurrentTenantsByLandID(selectedLand.LandID);

            try
            {
                ComboBoxCurrentTenant.DataSource = currentTenant;
                ComboBoxCurrentTenant.DisplayMember = "Fullname";
                ComboBoxCurrentTenant.ValueMember = "TenantID";

                LoadComboBoxNewTenant();
            }
            catch (Exception)
            {
                MessageForm messageForm = new MessageForm();
                messageForm.MessageText = "ओहो! केही आन्तरिक त्रुटीको कारण मोहीको विवरण लोड गर्न सकिएन।";
                messageForm.ShowDialog();
            }

            EnableDisableRadioButtons();
        }

        private void ComboBoxCurrentTenant_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadComboBoxNewTenant();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Either register new tenant or transfer ownership from
            // existing tenant to new tenant.

            // If current tenant is empty, we must register new tenant
            // otherwise we must transfer ownership.
            LeaseDA leaseDA = new LeaseDA();
            Land land = (Land)ComboBoxLand.SelectedItem;
            Tenant newTenant = (Tenant)ComboBoxNewTenant.SelectedItem;
            
            MessageForm messageForm;
            bool result = false;

            Lease newLease = new Lease();
            newLease.LeaseLand = land;
            newLease.LeaseTenant = newTenant;
            newLease.LeaseFrom = TextBoxLeaseFrom.Text;
            newLease.AnnualRent = TextBoxAnnualRent.Text;
            newLease.Remarks = TextBoxRemarks.Text;

            if (ComboBoxCurrentTenant.Items.Count > 0)
            {
                // Check the action and act accordingly

                // Transfer tenant ownership
                if (RadioButtonActionTransferRegistration.Checked)
                {
                    Tenant currentTenant = (Tenant)ComboBoxCurrentTenant.SelectedItem;

                    result = leaseDA.TransferLease(currentTenant, newLease);

                    if (result)
                    {
                        messageForm = new MessageForm();
                        messageForm.MessageText = "मोही हस्तान्तरणको विवरण सफलतापूर्वक सुरक्षित गरियो।";
                        messageForm.ShowDialog();
                    }
                }

                // Joint registration
                if (RadioButtonActionJointRegistration.Checked)
                {
                    // Check if this lease is already assigned
                    if (!leaseDA.IsDuplicateLease(newLease))
                    {
                        // Save new lease
                        try
                        {
                            result = leaseDA.SaveLease(newLease);
                        }
                        catch (Exception)
                        {
                            messageForm = new MessageForm();
                            messageForm.MessageText = "ओहो! केही आन्तरिक त्रुटीको कारण मोही दर्ताको विवरण सुरक्षित गर्न सकिएन।";
                            messageForm.ShowDialog();
                        }

                        if (result)
                        {
                            messageForm = new MessageForm();
                            messageForm.MessageText = "मोही दतार्को विवरण सफलतापूर्वक सुरक्षित गरियो।";
                            messageForm.ShowDialog();
                        }

                        // Clear fields for new entry
                        ClearFields();
                    }
                    else
                    {
                        // duplicate lease
                        messageForm = new MessageForm();
                        messageForm.MessageText = $"उक्त जग्गा पहिले नै {newTenant.Fullname}को नाममा दर्ता भइसकेको छ।";
                        messageForm.ShowDialog();
                    }
                }
            }
            else
            {
                // Register new tenant
                // Check if this lease is already assigned
                if (!leaseDA.IsDuplicateLease(newLease))
                {
                    // Save new lease
                    try
                    {
                        result = leaseDA.SaveLease(newLease);
                    }
                    catch (Exception)
                    {
                        messageForm = new MessageForm();
                        messageForm.MessageText = "ओहो! केही आन्तरिक त्रुटीको कारण मोही दर्ताको विवरण सुरक्षित गर्न सकिएन।";
                        messageForm.ShowDialog();
                    }

                    if (result)
                    {
                        messageForm = new MessageForm();
                        messageForm.MessageText = "मोही दतार्को विवरण सफलतापूर्वक सुरक्षित गरियो।";
                        messageForm.ShowDialog();
                    }

                    // Clear fields for new entry
                    ClearFields();
                }
                else
                {
                    // duplicate lease
                    messageForm = new MessageForm();
                    messageForm.MessageText = $"उक्त जग्गा पहिले नै {newTenant.Fullname}को नाममा दर्ता भइसकेको छ।";
                    messageForm.ShowDialog();
                }
            }
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxLeaseFrom_TextChanged(object sender, EventArgs e)
        {
            EnableDisableSaveButton();
        }

        private void TextBoxAnnualRent_TextChanged(object sender, EventArgs e)
        {
            EnableDisableSaveButton();
        }

        private void EnableDisableSaveButton()
        {
            if (ComboBoxLocation.Items.Count > 0 && ComboBoxLand.Items.Count > 0 && ComboBoxNewTenant.Items.Count > 0 && TextBoxLeaseFrom.TextLength > 0 && TextBoxAnnualRent.TextLength > 0)
            {
                ButtonSave.Enabled = true;
            }
            else
            {
                ButtonSave.Enabled = false;
            }
        }

        private void EnableDisableRadioButtons()
        {
            if (ComboBoxCurrentTenant.Items.Count > 0)
            {
                RadioButtonActionJointRegistration.Enabled = true;
                RadioButtonActionTransferRegistration.Enabled = true;
            }
            else
            {
                RadioButtonActionJointRegistration.Enabled = false;
                RadioButtonActionTransferRegistration.Enabled = false;
            }
        }

        private void ClearFields()
        {
            TextBoxLeaseFrom.Text = "";
            TextBoxAnnualRent.Text = "";
            TextBoxRemarks.Text = "";

            ComboBoxLocation.Focus();
        }

        private void LoadComboBoxNewTenant()
        {
            TenantDA tenantDA = new TenantDA();

            if (ComboBoxCurrentTenant.Items.Count > 0)
            {
                Tenant tenant = (Tenant)ComboBoxCurrentTenant.SelectedItem;
                ComboBoxNewTenant.DataSource = tenantDA.GetAllTenantsExcept(tenant.TenantID);
            }
            else
            {
                ComboBoxNewTenant.DataSource = tenantDA.GetAllTenants();
            }

            ComboBoxNewTenant.DisplayMember = "Fullname";
            ComboBoxNewTenant.ValueMember = "TenantID";
        }

        private void LoadCurrentTenantLeaseDetails()
        {
            // TODO - Fetch and display current tenant's lease details.
            //if (ComboBoxCurrentTenant.Items.Count > 0)
            //{
            //    Tenant tenant = (Tenant)ComboBoxCurrentTenant.SelectedItem;
                
            //}
            //else
            //{
                
            //}
        }

        private void PopulateLocations()
        {
            // Fill in Locations
            try
            {
                LocationDA locDA = new LocationDA();

                ComboBoxLocation.DataSource = locDA.GetLocationsHavingLands();
                ComboBoxLocation.DisplayMember = "LocationPreviousVDC";
                ComboBoxLocation.ValueMember = "LocationID";
            }
            catch (Exception)
            {
                MessageForm messageForm = new MessageForm();
                messageForm.MessageText = "ओहो! केही आन्तरिक त्रुटीको कारण जग्गा भएको स्थानको विवरण लोड गर्न सकिएन।";
                messageForm.ShowDialog();
            }
        }

    }
}
