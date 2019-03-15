using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ShadanandaGuthiLibrary;
using ShadanandaGuthiLibrary.DataAccess;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthi
{
    public partial class AllTenantsForm : Form
    {
        public AllTenantsForm()
        {
            InitializeComponent();
        }

        private void DataGridViewTenants_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = DataGridViewTenants.CurrentRow;
            PopulateLease(int.Parse(selectedRow.Tag.ToString()));

            EnableDisableEditButton();
            EnableDisableDeleteButton();
        }

        private void AllTenantsForm_Activated(object sender, EventArgs e)
        {
            PopulateTenants();

            EnableDisableEditButton();
            EnableDisableDeleteButton();
        }

        private void ButtonAddNewTenant_Click(object sender, EventArgs e)
        {
            NewTenantForm newTenant = new NewTenantForm();
            newTenant.ShowDialog();
        }

        private void ButtonDeleteTenant_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = DataGridViewTenants.CurrentRow;

            DialogResult dlgResult;
            ConfirmationForm confirmForm = new ConfirmationForm();
            confirmForm.ConfirmationText = "के तपाई मोहीको विवरण मेटाउन चाहनु हुन्छ ?";
            dlgResult = confirmForm.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                MessageForm messageForm;
                bool result = false;

                Tenant tenantToDelete = new Tenant();
                tenantToDelete.TenantID = int.Parse(selectedRow.Tag.ToString());

                try
                {
                    TenantDA tenantDA = new TenantDA();
                    result = tenantDA.DeleteTenant(tenantToDelete);
                }
                catch (Exception)
                {
                    messageForm = new MessageForm();
                    messageForm.MessageText = "आन्तरिक त्रुटीको कारण कार्य सम्पन्न गर्न सकिएन।";
                    messageForm.ShowDialog();
                }

                if (result)
                {
                    messageForm = new MessageForm();
                    messageForm.MessageText = "छनौट गरिएको मोहीको विवरण सफलतापूर्वक मेटाइयो।";
                    messageForm.ShowDialog();
                }
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonEditTenant_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = DataGridViewTenants.CurrentRow;
            int tenantID = int.Parse(selectedRow.Tag.ToString());
            TenantDA tenantDA = new TenantDA();
            Tenant tenantToEdit = tenantDA.GetTenantByID(tenantID);

            NewTenantForm editTenantForm = new NewTenantForm(tenantToEdit);
            editTenantForm.ShowDialog();
            
        }

        #region Private Helper Functions
        
        private void EnableDisableDeleteButton()
        {
            // If DataGridViewLease has no rows, we can assume 
            // the selected tenant has no lease. So we can
            // safely delete this tenant; enable the Delete button

            if (DataGridViewLeases.Rows.Count > 0 || DataGridViewTenants.Rows.Count == 0)
            {
                ButtonDeleteTenant.Enabled = false;
            }
            else
            {
                ButtonDeleteTenant.Enabled = true;
            }
        }

        private void EnableDisableEditButton()
        {
            // If DataGridViewTenants has no rows, we can assume 
            // there's no tenant info to edit, in that case disale
            // the Edit button. Otherwise, enable it.

            if (DataGridViewTenants.Rows.Count > 0)
            {
                ButtonEditTenant.Enabled = true;
            }
            else
            {
                ButtonEditTenant.Enabled = false;
            }
        }

        private void PopulateTenants()
        {
            TenantDA tenantDA = new TenantDA();
            List<Tenant> tenants = tenantDA.GetAllTenants();

            DataGridViewTenants.Rows.Clear();

            int i = 0;

            while (i < tenants.Count)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DataGridViewTenants);
                row.Cells[0].Value = Helper.GetNepaliNumber(i + 1);
                row.Cells[1].Value = tenants[i].Fullname;
                row.Cells[2].Value = tenants[i].Address;
                row.Cells[3].Value = tenants[i].MobileNumber;
                row.Cells[4].Value = tenants[i].Father;

                // Store land_id as Tag
                row.Tag = tenants[i].TenantID.ToString();

                DataGridViewTenants.Rows.Add(row);
                i++;
            }
        }

        private void PopulateLease(int tenantID)
        {
            LeaseDA leaseDA = new LeaseDA();

            DataTable leasesDT = leaseDA.GetLeaseByTenantID(tenantID);

            DataGridViewLeases.Rows.Clear();

            for (int i = 0; i <= leasesDT.Rows.Count - 1; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                //DataRow dataRow = leasesDT.Rows[i];

                row.CreateCells(DataGridViewLeases);
                row.Cells[0].Value = Helper.GetNepaliNumber(i + 1);
                row.Cells[1].Value = leasesDT.Rows[i][1];
                row.Cells[2].Value = leasesDT.Rows[i][2];
                row.Cells[3].Value = leasesDT.Rows[i][3];
                row.Cells[4].Value = leasesDT.Rows[i][4];
                row.Cells[5].Value = leasesDT.Rows[i][5];
                row.Cells[6].Value = leasesDT.Rows[i][6];
                row.Cells[7].Value = leasesDT.Rows[i][7];

                // Store land_id as Tag
                row.Tag = leasesDT.Rows[i][1];

                DataGridViewLeases.Rows.Add(row);
            }

        }

        #endregion

    }
}
