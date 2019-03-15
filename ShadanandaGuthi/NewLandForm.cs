using System;
using System.Windows.Forms;
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

        private void NewLandForm_Load(object sender, EventArgs e)
        {
            try
            {
                LocationDA locDA = new LocationDA();

                ComboBoxLocation.DataSource = locDA.GetLocations();
                ComboBoxLocation.DisplayMember = "LocationPreviousVDC";
                ComboBoxLocation.ValueMember = "LocationID";
            }
            catch (Exception)
            {
                MessageForm messageForm = new MessageForm();
                messageForm.MessageText = "ओहो! केही आन्तरिक त्रुटीको कारण जग्गा भएको स्थानको विवरण लोड गर्न सकिएन।";
                messageForm.ShowDialog();
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

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxPlotNumber_TextChanged(object sender, EventArgs e)
        {
            EnableDisableSaveButton();
        }

        private void TextBoxLandArea_TextChanged(object sender, EventArgs e)
        {
            EnableDisableSaveButton();
        }

        #region Private Helper Methods

        private void ClearFields()
        {
            ComboBoxLocation.SelectedIndex = 0;
            TextBoxPlotNumber.Text = "";
            TextBoxLandArea.Text = "";

            ComboBoxLocation.Focus();
        }

        private void EnableDisableSaveButton()
        {
            if (ComboBoxLocation.Items.Count > 0 && TextBoxPlotNumber.TextLength > 0 && TextBoxLandArea.TextLength > 0)
                ButtonSave.Enabled = true;
            else
                ButtonSave.Enabled = false;
        }

        #endregion

    }
}
