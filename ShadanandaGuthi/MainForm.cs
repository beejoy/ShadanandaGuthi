using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShadanandaGuthiLibrary.DataAccess;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            PopulateLocationListBox();
        }

        private void ToolStripMenuItemQuit_Click(object sender, EventArgs e)
        {
            this.Close();

            // TODO - Close the hidden Login Form also

        }

        private void ToolStripMenuItemNewLand_Click(object sender, EventArgs e)
        {
            NewLandForm newLand = new NewLandForm();
            newLand.ShowDialog();
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

        private void PopulateLocationListBox()
        {
            List<Location> locations = new List<Location>();
            LocationDA locDa = new LocationDA();

            locations = locDa.GetLocations();
            ListBoxLocations.DataSource = locations;
            ListBoxLocations.DisplayMember = "LocationPreviousVDC";
            ListBoxLocations.ValueMember = "LocationID";

            // Need to call this to update label
            //ListBoxLocations.SelectedIndex = 0;
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
                row.Cells[0].Value = lands[i].LandLocation.LocationPreviousVDC;
                row.Cells[1].Value = lands[i].PlotNumber;
                row.Cells[2].Value = lands[i].LandArea;

                // Store land_id as Tag
                row.Tag = lands[i].LandID.ToString();

                DataGridViewLands.Rows.Add(row);
                i++;
            }

            // Update total number of lands in selected location (label text)
            // TODO - Need to update this label at first run
            LabelTotalLandsInSelectedLocation.Text = GetNepaliNumber(DataGridViewLands.Rows.GetRowCount(DataGridViewElementStates.Displayed));
        }

        private string GetNepaliNumber(int number)
        {
            List<string> nepaliNumbers = new List<string>() { "०", "१", "२", "३", "४", "५", "६", "७", "८", "९", "१०", "११", "१२", "१३", "१४", "१५", "१६", "१७", "१८", "१९", "२०" };

            if (number >= 0 && number <= 20)
                return nepaliNumbers[number];
            else
                return nepaliNumbers[0];
        }

        private void DataGridViewLands_SelectionChanged(object sender, EventArgs e)
        {
            TenantDA tenantDA = new TenantDA();

            DataGridViewRow selectedRow = DataGridViewLands.CurrentRow;
            List<Tenant> tenants = tenantDA.GetTenantsByLandID(int.Parse(selectedRow.Tag.ToString()));

            DataGridViewTenants.Rows.Clear();

            int i = 0;

            while (i < tenants.Count)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DataGridViewTenants);
                row.Cells[0].Value = tenants[i].Fullname;
                row.Cells[1].Value = tenants[i].Address;
                row.Cells[2].Value = tenants[i].MobileNumber;
                row.Cells[3].Value = tenants[i].Father;

                // Store land_id as Tag
                row.Tag = tenants[i].TenantID.ToString();

                DataGridViewTenants.Rows.Add(row);
                i++;
            }
        }

        private void DataGridViewTenants_SelectionChanged(object sender, EventArgs e)
        {
            TenantDA tenantDA = new TenantDA();
            int tenantID = int.Parse(DataGridViewTenants.CurrentRow.Tag.ToString());
            MessageBox.Show($"Tenant's fullname = {tenantDA.GetTenantByID(tenantID).Fullname}");
        }
    }
}
