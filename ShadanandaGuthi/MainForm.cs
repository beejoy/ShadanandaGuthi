using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShadanandaGuthiLibrary;
using ShadanandaGuthiLibrary.DataAccess;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            PopulateLocationListBox();
        }
        
        #region ToolStripMenu Commands

        private void ToolStripMenuItemQuit_Click(object sender, EventArgs e)
        {
            this.Close();

            // TODO - Close the hidden Login Form also

        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItemNewLand_Click(object sender, EventArgs e)
        {
            NewLandForm newLand = new NewLandForm();
            newLand.ShowDialog();
        }

        private void ToolStripMenuItemLandList_Click(object sender, EventArgs e)
        {
            try
            {
                AllLandsForm allLandsForm = new AllLandsForm();
                allLandsForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageForm messageForm = new MessageForm();
                messageForm.MessageText = "अनुप्रयोगको आन्तरिक प्रणाली सुरु हुँदैछ। केही बेर पर्खनु होला।";
                messageForm.ShowDialog();
            }
        }

        private void ToolStripMenuItemNewTenant_Click(object sender, EventArgs e)
        {
            NewTenantForm newTenant = new NewTenantForm();
            newTenant.ShowDialog();
        }

        private void ToolStripMenuItemNewLocation_Click(object sender, EventArgs e)
        {
            NewLocationForm newLocation = new NewLocationForm();
            newLocation.ShowDialog();
        }

        private void ToolStripMenuItemTenantRegisterAndTransfer_Click(object sender, EventArgs e)
        {
            TenantRegisterAndTransferForm newTenantRegister = new TenantRegisterAndTransferForm();
            newTenantRegister.ShowDialog();
        }

        private void ToolStripMenuItemTenantDeregister_Click(object sender, EventArgs e)
        {
            TenantDeregisterForm deregisterForm = new TenantDeregisterForm();
            deregisterForm.ShowDialog();
        }

        private void ToolStripMenuItemTenantList_Click(object sender, EventArgs e)
        {
            AllTenantsForm allTenantsForm = new AllTenantsForm();
            allTenantsForm.ShowDialog();
        }

        private void ToolStripMenuItemCurrentYear_Click(object sender, EventArgs e)
        {
            CurrentYearForm currentYearForm = new CurrentYearForm();
            currentYearForm.ShowDialog();
        }

        private void ToolStripMenuItemLeaseRentPayment_Click(object sender, EventArgs e)
        {
            LeasePaymentForm leasePaymentForm = new LeasePaymentForm();
            leasePaymentForm.ShowDialog();
        }

        private void ToolStripMenuItemRentPaidByTenant_Click(object sender, EventArgs e)
        {
            TenantwiseLeasePaymentDetailForm paymentDetailForm = new TenantwiseLeasePaymentDetailForm();
            paymentDetailForm.ShowDialog();
        }

        private void ToolStripMenuItemRentPaidByAllTenants_Click(object sender, EventArgs e)
        {
            AllLeasePaymentDetailForm allPaymentDetailsForm = new AllLeasePaymentDetailForm();
            allPaymentDetailsForm.ShowDialog();
        }

        #endregion

        private void ListBoxLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            LandDA landDA = new LandDA();
            Location location = (Location)ListBoxLocations.SelectedItem;
            List<Land> lands = landDA.GetLandsByLocation(location);

            DataGridViewLands.Rows.Clear();

            int i = 0;
            
            while (i < lands.Count)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DataGridViewLands);
                row.Cells[0].Value = Helper.GetNepaliNumber(i + 1);
                row.Cells[1].Value = lands[i].LandLocation.LocationPreviousVDC;
                row.Cells[2].Value = lands[i].PlotNumber;
                row.Cells[3].Value = lands[i].LandArea;

                // Store land_id as Tag
                row.Tag = lands[i].LandID.ToString();

                DataGridViewLands.Rows.Add(row);
                i++;
            }

            // Update total number of lands in selected location (label text)
            LabelTotalLandsInSelectedLocation.Text = $"जम्मा जग्गा (कित्ता) संख्या :  {Helper.GetNepaliNumber(lands.Count)}";
        }

        private void DataGridViewLands_SelectionChanged(object sender, EventArgs e)
        {
            LeaseDA leaseDA = new LeaseDA();

            DataGridViewRow selectedRow = DataGridViewLands.CurrentRow;
            List<Tenant> tenants = leaseDA.GetCurrentTenantsByLandID(int.Parse(selectedRow.Tag.ToString()));

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

        private void PopulateLocationListBox()
        {
            List<Location> locations = new List<Location>();
            LocationDA locDa = new LocationDA();

            locations = locDa.GetLocationsHavingLands();
            ListBoxLocations.DataSource = locations;
            ListBoxLocations.DisplayMember = "LocationPreviousVDC";
            ListBoxLocations.ValueMember = "LocationID";
        }

    }
}
