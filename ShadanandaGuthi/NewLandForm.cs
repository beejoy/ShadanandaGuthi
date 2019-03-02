using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using ShadanandaGuthiLibrary.DataAccess;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthi
{
    public partial class NewLandForm : Form
    {
        Location location = new Location();

        public NewLandForm()
        {
            InitializeComponent();
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewLandForm_Load(object sender, EventArgs e)
        {
            try
            {
                LocationDA locDA = new LocationDA();
                //DataTable locationsDT = locDA.GetAllLocations();

                //ComboBoxLocation.DataSource = locationsDT;
                //ComboBoxLocation.DisplayMember = "location";
                //ComboBoxLocation.ValueMember = "location_id";

                ComboBoxLocation.DataSource = locDA.GetLocations();
            }
            catch (Exception ex)
            {
                // TODO - Handle exception
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // TODO - Implement code for saving new Land.

            // Clear fields for new entry
            ClearFields();
        }

        #region Private Helper Methods

        private void ClearFields()
        {
            ComboBoxLocation.SelectedIndex = 0;
            TextBoxPlotNumber.Text = "";
            TextBoxLandArea.Text = "";

            ComboBoxLocation.Focus();
        }
        #endregion

        private void ComboBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            location = (Location)ComboBoxLocation.Items[ComboBoxLocation.SelectedIndex];
            //MessageBox.Show($"{location.LocationPreviousVDC} - {location.LocationNewLevel}", "SelectedIndexChanged");
        }

        private void TextBoxPlotNumber_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxPlotNumber.TextLength > 0 && TextBoxLandArea.TextLength > 0)
                ButtonSave.Enabled = true;
            else
                ButtonSave.Enabled = false;
        }

        private void TextBoxLandArea_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxPlotNumber.TextLength > 0 && TextBoxLandArea.TextLength > 0)
                ButtonSave.Enabled = true;
            else
                ButtonSave.Enabled = false;
        }
    }
}
