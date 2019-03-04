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

                ComboBoxLocation.DataSource = locDA.GetLocations();
                ComboBoxLocation.DisplayMember = "LocationPreviousVDC";
                ComboBoxLocation.ValueMember = "LocationID";
            }
            catch (Exception ex)
            {
                // TODO - Handle exception
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Check if the land is duplicate
            LandDA landDA = new LandDA();
            MessageForm messageForm;

            Land newLand = new Land();
            newLand.LandLocation = (Location)ComboBoxLocation.SelectedItem;
            newLand.PlotNumber = TextBoxPlotNumber.Text;
            newLand.LandArea = TextBoxLandArea.Text;

            bool result = false;

            if (!landDA.IsDuplicateLand(newLand))
            {
                try
                {
                    result = landDA.SaveLand(newLand);
                }
                catch (Exception)
                {
                    messageForm = new MessageForm();
                    messageForm.MessageText = "ओहो! केही आन्तरिक त्रुटीको कारण नयाँ जग्गाको विवरण सुरक्षित गर्न सकिएन।";
                    messageForm.ShowDialog();
                }

                if (result)
                {
                    messageForm = new MessageForm();
                    messageForm.MessageText = "नयाँ जग्गाको विवरण सफलतापूर्वक सुरक्षित गरियो।";
                    messageForm.ShowDialog();
                }

                // Clear fields for new entry
                ClearFields();
            }
            else
            {
                messageForm = new MessageForm();
                messageForm.MessageText = "उक्त जग्गाको विवरण पहिले नै सुरक्षित गरिसकेको छ।";
                messageForm.ShowDialog();
            }
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
            // TODO - Remove or comment these line in relase build.
            Location loc = (Location)ComboBoxLocation.SelectedItem;
            this.Text=$"{loc.LocationID} - {loc.LocationPreviousVDC}";
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
