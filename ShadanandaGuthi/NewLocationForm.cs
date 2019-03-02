using System;
using System.Windows.Forms;
using ShadanandaGuthiLibrary.DataAccess;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthi
{
    public partial class NewLocationForm : Form
    {
        Location newLocation = new Location();

        public NewLocationForm()
        {
            InitializeComponent();
        }

        #region Control Event Handlers
        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            LocationDA locationDA = new LocationDA();
            MessageForm messageForm;

            newLocation.LocationPreviousVDC = TextBoxLocation.Text;
            newLocation.LocationNewLevel = TextBoxLocalLevel.Text;
            bool result = false;

            if (!locationDA.IsDuplicateLocation(newLocation) && !String.IsNullOrEmpty(newLocation.LocationNewLevel))
            {
                try
                {
                    result = locationDA.SaveLocation(newLocation);
                }
                catch (Exception ex)
                {
                    // TODO - Handle exception
                    MessageBox.Show("Exception in Save_Click.");
                }

                if (result)
                {   
                    messageForm = new MessageForm();
                    messageForm.MessageText = "नयाँ स्थानको विवरण सफलतापूर्वक सुरक्षित गरियो।";
                    messageForm.ShowDialog();
                }

                // Clear fields for new entry
                ClearFields();
            }
            else
            {
                messageForm = new MessageForm();
                messageForm.MessageText = "उक्त स्थानको विवरण पहिले नै सुरक्षित गरिसकेको छ।";
                messageForm.ShowDialog();
            }
        }

        private void TextBoxLocation_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxLocation.TextLength > 0 && TextBoxLocalLevel.TextLength > 0)
                ButtonSave.Enabled = true;
            else
                ButtonSave.Enabled = false;
        }

        private void TextBoxLocalLevel_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxLocation.TextLength > 0 && TextBoxLocalLevel.TextLength > 0)
                ButtonSave.Enabled = true;
            else
                ButtonSave.Enabled = false;
        }
        #endregion

        #region Private Helper Methods

        private void ClearFields()
        {
            TextBoxLocation.Text = "";
            TextBoxLocalLevel.Text = "";
            TextBoxLocation.Focus();
        }
        #endregion
    }
}
