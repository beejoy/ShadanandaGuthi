using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void PopulateLocationListBox()
        {
            List<Location> locations = new List<Location>()
            //locations.Add(new Location(1, "केउरेनीपानी-२", "षडानन्द-६"));
            //locations.Add(new Location(2, "केउरेनीपानी-3", "षडानन्द-६"));
            //locations.Add(new Location(3, "कुदाककाउले-१", "षडानन्द-"));
            //locations.Add(new Location(4, "कुदाककाउले-५", "षडानन्द-"));
            //locations.Add(new Location(5, "तुङ्गेछा-५", "षडानन्द-"));
            //locations.Add(new Location(6, "तुङ्गेछा-७", "षडानन्द-"));
            //locations.Add(new Location(7, "मुलपानी-१", "षडानन्द-"));
            //locations.Add(new Location(8, "मुलपानी-२", "षडानन्द-४"));

            {
                new Location() { LocationID=1, LocationPreviousVDC="केउरेनीपानी-२", LocationNewLevel="षडानन्द-६" },
                new Location() { LocationID=2, LocationPreviousVDC="केउरेनीपानी-३", LocationNewLevel="षडानन्द-६" },
                new Location() { LocationID=3, LocationPreviousVDC="मुलपानी-२", LocationNewLevel="षडानन्द-४" },
                new Location() { LocationID=4, LocationPreviousVDC="मुलपानी-५", LocationNewLevel="षडानन्द-४" },
                new Location() { LocationID=5, LocationPreviousVDC="मुलपानी-७", LocationNewLevel="षडानन्द-५" },
                new Location() { LocationID=6, LocationPreviousVDC="तुङ्गेछा-४", LocationNewLevel="षडानन्द-८" },
                new Location() { LocationID=7, LocationPreviousVDC="तुङ्गेछा-७", LocationNewLevel="षडानन्द-८" },
                new Location() { LocationID=8, LocationPreviousVDC="नेपालेडाँडा-१", LocationNewLevel="षडानन्द-१" },
                new Location() { LocationID=9, LocationPreviousVDC="खार्तम्छा-८", LocationNewLevel="षडानन्द-३" }
            };
            ListBoxLocations.DataSource = locations;
        }

        private void MainForm_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("MainForm_Activated", "MainForm");
        }

        private void ToolStripMenuItemNewLocation_Click(object sender, EventArgs e)
        {
            NewLocationForm newLocation = new NewLocationForm();
            newLocation.ShowDialog();
        }
    }
}
