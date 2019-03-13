using System;
using System.Windows.Forms;
using ShadanandaGuthiLibrary.DataAccess;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthi
{
    public partial class NewTenantForm : Form
    {
        Tenant tenant = new Tenant();

        public NewTenantForm()
        {
            InitializeComponent();
        }

        public NewTenantForm(Tenant existingTenant)
        {
            InitializeComponent();
            tenant = existingTenant;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Check if the land is duplicate
            TenantDA tenantDA = new TenantDA();
            MessageForm messageForm = new MessageForm();

            // If tenant.TenantID is null, it is new tenant. So proceed with Save.
            // Otherwise, proceed with updating tenant.
            bool result = false;

            tenant.Fullname = TextBoxFullname.Text;
            tenant.Address = TextBoxAddress.Text;
            tenant.MobileNumber = TextBoxMobileNumber.Text;
            tenant.Father = TextBoxFather.Text;

            if (tenant.TenantID < 1)
            {
                if (!tenantDA.IsDuplicateTenant(tenant))
                {
                    try
                    {
                        result = tenantDA.SaveTenant(tenant);
                    }
                    catch (Exception)
                    {
                        messageForm.MessageText = "ओहो! केही आन्तरिक त्रुटीको कारण नयाँ मोहीको विवरण सुरक्षित गर्न सकिएन।";
                        messageForm.ShowDialog();
                    }

                    if (result)
                    {
                        messageForm.MessageText = "नयाँ मोहीको विवरण सफलतापूर्वक सुरक्षित गरियो।";
                        messageForm.ShowDialog();
                    }

                    // Clear fields for new entry
                    ClearFields();
                }
                else
                {
                    messageForm.MessageText = "उक्त मोहीको विवरण पहिले नै सुरक्षित गरिसकेको छ।";
                    messageForm.ShowDialog();
                }
            }
            else
            {
                try
                {
                    result = tenantDA.UpdateTenant(tenant);
                }
                catch (Exception)
                {
                    messageForm.MessageText = "केही आन्तरिक त्रुटीको कारण मोहीको विवरण सच्याउन सकिएन।";
                    messageForm.ShowDialog();
                }

                if (result)
                {
                    messageForm.MessageText = "उक्त मोहीको विवरण सफलतापूर्वक अद्यावधिक गरियो।";
                    messageForm.ShowDialog();
                }
            }

            // If edit mode, then self close the form
            if (tenant.TenantID > 0)
            {
                this.Close();
            }
        }

        private void ClearFields()
        {
            TextBoxFullname.Text = "";
            TextBoxAddress.Text = "";
            TextBoxMobileNumber.Text = "";
            TextBoxFather.Text = "";

            TextBoxFullname.Focus();
        }

        private void EnableDisableSaveButton()
        {
            // Tenant's fullname, address and father name are mandatory to save record
            if (TextBoxFullname.TextLength > 0 && TextBoxAddress.TextLength > 0 && TextBoxFather.TextLength > 0)
                ButtonSave.Enabled = true;
            else
                ButtonSave.Enabled = false;
        }

        private void TextBoxFullname_TextChanged(object sender, EventArgs e)
        {
            EnableDisableSaveButton();
        }

        private void TextBoxAddress_TextChanged(object sender, EventArgs e)
        {
            EnableDisableSaveButton();
        }

        private void TextBoxMobileNumber_TextChanged(object sender, EventArgs e)
        {
            EnableDisableSaveButton();
        }

        private void TextBoxFather_TextChanged(object sender, EventArgs e)
        {
            EnableDisableSaveButton();
        }

        private void NewTenantForm_Load(object sender, EventArgs e)
        {
            if (tenant != null)
            {
                TextBoxFullname.Text=tenant.Fullname ;
                TextBoxAddress.Text = tenant.Address;
                TextBoxMobileNumber.Text = tenant.MobileNumber;
                TextBoxFather.Text = tenant.Father;
            }
        }
    }
}
