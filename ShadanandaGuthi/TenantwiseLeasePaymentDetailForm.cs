using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ShadanandaGuthiLibrary;
using ShadanandaGuthiLibrary.DataAccess;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthi
{
    public partial class TenantwiseLeasePaymentDetailForm : Form
    {
        public TenantwiseLeasePaymentDetailForm()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TenantwiseLeasePaymentDetailForm_Load(object sender, EventArgs e)
        {
            PopulateRentYears();
            PopulateTenants();
        }

        private void TextBoxFilterTenantName_TextChanged(object sender, EventArgs e)
        {
            PopulateTenants(TextBoxFilterTenantName.Text);
        }

        private void DataGridViewTenants_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridViewTenants.Rows.Count > 0)
            {
                // Make sure there's at least one RentYear in the combobox
                if (ComboBoxRentYear.Items.Count > 0)
                {
                    UpdatePaymentDetailsDGV();
                }
                PopulateLeasedLands();
            }
        }

        private void ComboBoxRentYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Act only if DataGridViewTenants is populated
            if (DataGridViewTenants.Rows.Count > 0 && ComboBoxRentYear.Items.Count > 0)
            {
                UpdatePaymentDetailsDGV();
            }
        }

        #region Private helper functions

        private void PopulateLeasedLands()
        {
            try
            {
                // Retrieve the TenantID
                DataGridViewRow selectedTenant = DataGridViewTenants.CurrentRow;
                int tenantID = int.Parse(selectedTenant.Tag.ToString());

                LeaseDA leaseDA = new LeaseDA();
                List<LeaseLand> leasedLands = leaseDA.GetLeaseLandByTenantID(tenantID);
                ListBoxLeasedLands.DataSource = leasedLands;
                ListBoxLeasedLands.DisplayMember = "LandInfo";
                ListBoxLeasedLands.ValueMember = "LeaseID";
            }
            catch (Exception)
            {
                MessageForm messageForm = new MessageForm();
                messageForm.MessageText = "केहीको प्राविधिक कारणले गर्दा कार्य सम्पन्न गर्न सकिएन।";
                messageForm.ShowDialog();
            }
        }

        private void PopulateTenants(string filter = "")
        {
            TenantDA tenantDA = new TenantDA();
            List<Tenant> tenants = tenantDA.GetActiveTenants(filter);

            DataGridViewTenants.Rows.Clear();
            DataGridViewPaymentDetails.Rows.Clear();

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

                // Store tenant_id as Tag
                row.Tag = tenants[i].TenantID.ToString();

                DataGridViewTenants.Rows.Add(row);
                i++;
            }
        }

        private void PopulateRentYears()
        {
            RentYearDA rentYearDA = new RentYearDA();
            List<RentYear> rentYears = rentYearDA.GetAllRentYears();

            ComboBoxRentYear.DataSource = rentYears;
            ComboBoxRentYear.DisplayMember = "TheRentYear";
            ComboBoxRentYear.ValueMember = "YearID";
        }
        
        private void UpdatePaymentDetailsDGV()
        {
            DataGridViewPaymentDetails.Rows.Clear();

            // Retrieve the TenantID
            DataGridViewRow selectedTenant = DataGridViewTenants.CurrentRow;
            int tenantID = int.Parse(selectedTenant.Tag.ToString());

            // Retrieve the RentYearID
            RentYear selectedRentYear = (RentYear)ComboBoxRentYear.SelectedItem;
            int rentYearID = selectedRentYear.YearID;

            // Retrieve records of LeasePayment for TenantID for RentYearID
            LeasePaymentDA paymentDA = new LeasePaymentDA();
            DataTable paymentDetailsDT = paymentDA.GetLeasePaymentDetailsByTenantIDYearID(tenantID, rentYearID);

            DataGridViewPaymentDetails.Rows.Clear();

            for (int i = 0; i <= paymentDetailsDT.Rows.Count - 1; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(DataGridViewPaymentDetails);
                row.Cells[0].Value = Helper.GetNepaliNumber(i + 1);
                row.Cells[1].Value = paymentDetailsDT.Rows[i][1];
                row.Cells[2].Value = paymentDetailsDT.Rows[i][2];
                row.Cells[3].Value = paymentDetailsDT.Rows[i][3];
                row.Cells[4].Value = paymentDetailsDT.Rows[i][4];
                row.Cells[5].Value = paymentDetailsDT.Rows[i][5];
                row.Cells[6].Value = paymentDetailsDT.Rows[i][6];
                row.Cells[7].Value = paymentDetailsDT.Rows[i][7];
                row.Cells[8].Value = paymentDetailsDT.Rows[i][8];

                // Store land_id as Tag
                row.Tag = paymentDetailsDT.Rows[i][1];

                DataGridViewPaymentDetails.Rows.Add(row);
            }
        }

        #endregion

    }
}
