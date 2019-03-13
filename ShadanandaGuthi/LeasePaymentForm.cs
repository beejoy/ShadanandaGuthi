using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ShadanandaGuthiLibrary.DataAccess;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthi
{
    public partial class LeasePaymentForm : Form
    {
        public LeasePaymentForm()
        {
            InitializeComponent();
        }

        private void LeasePaymentForm_Load(object sender, EventArgs e)
        {
            PopulateTenants();
            PopulateRentYears();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            LeasePaymentDA leasePaymentDA = new LeasePaymentDA();

            Tenant selectedTenant = (Tenant)ComboBoxTenant.SelectedItem;
            LeaseLand leasedLand = (LeaseLand)ComboBoxLeaseLand.SelectedItem;
            RentYear rentYear = (RentYear)ComboBoxRentYear.SelectedItem;

            MessageForm messageForm = new MessageForm();

            if (!leasePaymentDA.IsDuplicatePayment(leasedLand.LeaseID, rentYear.YearID))
            {
                LeasePayment newLeasePayment = new LeasePayment();
                newLeasePayment.LeaseID = leasedLand.LeaseID;
                newLeasePayment.YearID = rentYear.YearID;
                newLeasePayment.LeaseRent = TextBoxAnnualRent.Text;
                newLeasePayment.PaymentDate = TextBoxPaymentDate.Text;
                newLeasePayment.ReceiptNumber = TextBoxReceiptNumber.Text;
                newLeasePayment.Remarks = TextBoxRemarks.Text;

                bool success = leasePaymentDA.SaveLeasePayment(newLeasePayment);

                if (success)
                {
                    messageForm.MessageText = $"उक्त जग्गाको {rentYear.TheRentYear} सालको ठेक्का बुझाएको अभिलेख सुरक्षित गरियो।";
                }
                else
                {
                    messageForm.MessageText = $"प्राविधिक कारणले गर्दा उक्त ठेक्का बुझाएको विवरण सुरक्षित गर्न सकिएन।";
                }
                messageForm.ShowDialog();
            }
            else
            {
                messageForm.MessageText = $"उक्त जग्गाको {rentYear.TheRentYear} सालको ठेक्का बुझाइसकेको छ।";
                messageForm.ShowDialog();
            }

            ClearFields();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxTenant_SelectedIndexChanged(object sender, EventArgs e)
        {
            LeaseDA leaseDA = new LeaseDA();
            Tenant selectedTenant = (Tenant)ComboBoxTenant.SelectedItem;

            List<LeaseLand> leaseLand = leaseDA.GetLeaseLandByTenantID(selectedTenant.TenantID);
            ComboBoxLeaseLand.DataSource = leaseLand;
            ComboBoxLeaseLand.DisplayMember = "LandInfo";
            ComboBoxLeaseLand.ValueMember = "LeaseID";
        }

        private void TextBoxAnnualRent_TextChanged(object sender, EventArgs e)
        {
            EnableDisableSaveButton();
        }

        private void TextBoxPaymentDate_TextChanged(object sender, EventArgs e)
        {
            EnableDisableSaveButton();
        }

        #region --- PRIVATE HELPER FUNCTIONS ---

        private void ClearFields()
        {
            TextBoxAnnualRent.Text = "";
            TextBoxPaymentDate.Text = "";
            TextBoxReceiptNumber.Text = "";
            TextBoxRemarks.Text = "";

            ComboBoxTenant.Focus();
        }

        private void EnableDisableSaveButton()
        {
            if (ComboBoxTenant.SelectedIndex == -1 || ComboBoxRentYear.SelectedIndex == -1 || TextBoxAnnualRent.TextLength == 0 || TextBoxPaymentDate.TextLength == 0)
            {
                ButtonSave.Enabled = false;
            }
            else
            {
                ButtonSave.Enabled = true;
            }
        }

        private void PopulateTenants()
        {
            TenantDA tenantDA = new TenantDA();

            ComboBoxTenant.DataSource = tenantDA.GetActiveTenants();
            ComboBoxTenant.DisplayMember = "Fullname";
            ComboBoxTenant.ValueMember = "TenantID";
        }

        private void PopulateRentYears()
        {
            RentYearDA rentYearDA = new RentYearDA();

            ComboBoxRentYear.DataSource = rentYearDA.GetAllRentYears();
            ComboBoxRentYear.DisplayMember = "TheRentYear";
            ComboBoxRentYear.ValueMember = "YearID";
        }

        #endregion

    }
}
