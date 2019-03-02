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

            PopulateLandGridView();
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

        private void PopulateLandGridView()
        {
            //List<Land> lands = new List<Land>();
            //lands.Add(new Land(1, new Location(1,"केउरेनीपानी-२","षडानन्द-६"), "२९", "०-१३-२-२"));
            //lands.Add(new Land(2, new Location(2,"केउरेनीपानी-३","षडानन्द-६"), "१२९", "१-३-०-२"));
            //lands.Add(new Land(3, new Location(8,"मुलपानी-२","षडानन्द-४"), "२०९", "५-०-३-१"));
            //lands.Add(new Land(4, new Location(8,"मुलपानी-५","षडानन्द-४"), "३१२", "१०-१-१-०"));
            //lands.Add(new Land(5, new Location(8,"मुलपानी-५","षडानन्द-४"), "३१४", "९-८-०-३"));

            //dataGridView1.DataSource = lands;
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
