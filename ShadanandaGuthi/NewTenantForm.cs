using System;
using System.Windows.Forms;
using ShadanandaGuthiLibrary.DataAccess;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthi
{
    public partial class NewTenantForm : Form
    {
        public NewTenantForm()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Check if the land is duplicate
            TenantDA tenantDA = new TenantDA();
            MessageForm messageForm;

            Tenant newTenant = new Tenant();
            newTenant.Fullname = TextBoxFullname.Text;
            newTenant.Address = TextBoxAddress.Text;
            newTenant.MobileNumber = TextBoxMobileNumber.Text;
            newTenant.Father = TextBoxFather.Text;

            bool result = false;

            if (!tenantDA.IsDuplicateTenant(newTenant))
            {
                try
                {
                    result = tenantDA.SaveTenant(newTenant);
                }
                catch (Exception)
                {
                    messageForm = new MessageForm();
                    messageForm.MessageText = "ओहो! केही आन्तरिक त्रुटीको कारण नयाँ मोहीको विवरण सुरक्षित गर्न सकिएन।";
                    messageForm.ShowDialog();
                }

                if (result)
                {
                    messageForm = new MessageForm();
                    messageForm.MessageText = "नयाँ मोहीको विवरण सफलतापूर्वक सुरक्षित गरियो।";
                    messageForm.ShowDialog();
                }

                // Clear fields for new entry
                ClearFields();
            }
            else
            {
                messageForm = new MessageForm();
                messageForm.MessageText = "उक्त मोहीको विवरण पहिले नै सुरक्षित गरिसकेको छ।";
                messageForm.ShowDialog();
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
    }
}
