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
            AllLandsForm allLandsForm = new AllLandsForm();
            allLandsForm.ShowDialog();
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

        private void PopulateLocationListBox()
        {
            List<Location> locations = new List<Location>();
            LocationDA locDa = new LocationDA();

            locations = locDa.GetLocationsHavingLands();
            ListBoxLocations.DataSource = locations;
            ListBoxLocations.DisplayMember = "LocationPreviousVDC";
            ListBoxLocations.ValueMember = "LocationID";
        }

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
            LabelTotalLandsInSelectedLocation.Text = Helper.GetNepaliNumber(lands.Count);
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

        private void ToolStripMenuItemTenantList_Click(object sender, EventArgs e)
        {
            AllTenantsForm allTenantsForm = new AllTenantsForm();
            allTenantsForm.ShowDialog();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            PopulateLocationListBox();
        }
    }
}
