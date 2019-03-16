using System;
using System.Data;
using System.Windows.Forms;
using ShadanandaGuthiLibrary;
using ShadanandaGuthiLibrary.DataAccess;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthi
{
    public partial class TenantDeregisterForm : Form
    {
        public TenantDeregisterForm()
        {
            InitializeComponent();
        }

        private void TenantDeregisterForm_Activated(object sender, EventArgs e)
        {
            PopulateTenants();
            EnableDisableDeregisterButton();
        }

        private void ComboBoxTenant_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tenant selectedTenant = (Tenant)ComboBoxTenant.SelectedItem;
            PopulateLease(selectedTenant.TenantID);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnableDisableDeregisterButton()
        {
            if (ComboBoxTenant.Items.Count > 0 && DataGridViewLeases.Rows.Count > 0)
            {
                ButtonDeregisterTenant.Enabled = true;
            }
            else
            {
                ButtonDeregisterTenant.Enabled = false;
            }
        }

        private void PopulateTenants()
        {
            TenantDA tenantDA = new TenantDA();

            ComboBoxTenant.DataSource = tenantDA.GetActiveTenants();
            ComboBoxTenant.DisplayMember = "Fullname";
            ComboBoxTenant.ValueMember = "TenantID";
        }

        private void PopulateLease(int tenantID)
        {
            LeaseDA leaseDA = new LeaseDA();

            DataTable leasesDT = leaseDA.GetLeaseByTenantID(tenantID);

            DataGridViewLeases.Rows.Clear();

            for (int i = 0; i <= leasesDT.Rows.Count - 1; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                // Add only active lease
                if (leasesDT.Rows[i][6].Equals(true))
                {
                    row.CreateCells(DataGridViewLeases);
                    row.Cells[0].Value = Helper.GetNepaliNumber(i + 1);
                    row.Cells[1].Value = leasesDT.Rows[i][1];
                    row.Cells[2].Value = leasesDT.Rows[i][2];
                    row.Cells[3].Value = leasesDT.Rows[i][3];
                    row.Cells[4].Value = leasesDT.Rows[i][4];
                    row.Cells[5].Value = leasesDT.Rows[i][5];
                    row.Cells[6].Value = leasesDT.Rows[i][7];

                    // Store land_id as Tag
                    row.Tag = leasesDT.Rows[i][0];

                    DataGridViewLeases.Rows.Add(row);
                }
            }
        }

        private void ButtonDeregisterTenant_Click(object sender, EventArgs e)
        {
            // Retrieve the LeaseID to deregister
            DataGridViewRow row = DataGridViewLeases.CurrentRow;

            ConfirmationForm confirmForm = new ConfirmationForm();
            confirmForm.ConfirmationText = "के तपाई वास्तवमै मोही दर्ता खारेज गर्न चाहनुहुन्छ?";

            DialogResult result = confirmForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                TenantDA tenantDA = new TenantDA();
                bool success = tenantDA.DeregisterLease(int.Parse(row.Tag.ToString()));

                MessageForm messageForm = new MessageForm();

                if (success)
                {
                    messageForm.MessageText = "मोही दर्ता सफलतापूर्वक खारेज गरियो।";
                    messageForm.ShowDialog();
                }
                else
                {
                    messageForm.MessageText = "प्राविधिक कारणले गर्दा र्मोही दर्ता खारेज गर्न सकिएन।";
                    messageForm.ShowDialog();
                }
            }
        }
    }
}
