using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShadanandaGuthiLibrary;
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

        private void NewLocationForm_Load(object sender, EventArgs e)
        {
            PopulateLocations();
        }

        private void DataGridViewLocations_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DataGridViewLocations.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGridViewLocations.CurrentRow;
                newLocation.LocationID = int.Parse(selectedRow.Tag.ToString());

                // Get the location details into textboxes
                TextBoxLocation.Text = selectedRow.Cells[1].Value.ToString();
                TextBoxLocalLevel.Text = selectedRow.Cells[2].Value.ToString();
            }
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            if (newLocation != null)
                newLocation = null;

            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            LocationDA locationDA = new LocationDA();
            MessageForm messageForm = new MessageForm();

            newLocation.LocationPreviousVDC = TextBoxLocation.Text;
            newLocation.LocationNewLevel = TextBoxLocalLevel.Text;
            bool result = false;

            if (newLocation.LocationID > 0)
            {
                if (!locationDA.IsDuplicateLocation(newLocation))
                {
                    // Update the location information
                    try
                    {
                        result = locationDA.UpdateLocation(newLocation);
                    }
                    catch (Exception)
                    {
                        messageForm.MessageText = "केही आन्तरिक त्रुटीको कारण स्थानको विवरण अद्यावधिक गर्न सकिएन।";
                        messageForm.ShowDialog();
                    }

                    if (result)
                    {
                        messageForm.MessageText = "उक्त स्थानको विवरण सफलतापूर्वक अद्यावधिक गरियो।";
                        messageForm.ShowDialog();
                    }
                }
                else
                {
                    messageForm.MessageText = "उक्त स्थानको विवरण पहिले नै सुरक्षित गरिसकेको छ।";
                    messageForm.ShowDialog();
                }
            }
            else
            {
                if (!locationDA.IsDuplicateLocation(newLocation))
                {
                    try
                    {
                        result = locationDA.SaveLocation(newLocation);
                    }
                    catch (Exception)
                    {
                        messageForm.MessageText = "ओहो! केही आन्तरिक त्रुटीको कारण नयाँ स्थानको विवरण सुरक्षित गर्न सकिएन।";
                        messageForm.ShowDialog();
                    }

                    if (result)
                    {
                        messageForm.MessageText = "नयाँ स्थानको विवरण सफलतापूर्वक सुरक्षित गरियो।";
                        messageForm.ShowDialog();
                    }
                }
                else
                {
                    messageForm.MessageText = "उक्त स्थानको विवरण पहिले नै सुरक्षित गरिसकेको छ।";
                    messageForm.ShowDialog();
                }
            }

            Sanitize();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (newLocation.LocationID > 0)
            {
                MessageForm messageForm = new MessageForm();
                LocationDA locationDA = new LocationDA();

                if (!locationDA.DoesLocationHaveLands(newLocation))
                {
                    bool success = locationDA.DeleteLocation(newLocation);
                    if (success)
                    {   
                        messageForm.MessageText = "उक्त स्थानको विवरण सफलतापूर्वक मेटाइयो।";
                        messageForm.ShowDialog();
                    }
                }
                else
                {
                    messageForm.MessageText = "उक्त स्थानमा जग्गा भएको हुँदा सो स्थानको विवरण मेटाउन सकिएन।";
                    messageForm.ShowDialog();
                }

                Sanitize();
            }
        }

        private void TextBoxLocation_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxLocation.TextLength > 0 && TextBoxLocalLevel.TextLength > 0)
            {
                ButtonSave.Enabled = true;
            }
            else
            {
                ButtonSave.Enabled = false;
            }

            if (newLocation.LocationID > 0)
            {
                ButtonDelete.Enabled = true;
            }
            else
            {
                ButtonDelete.Enabled = false;
            }
        }

        private void TextBoxLocalLevel_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxLocation.TextLength > 0 && TextBoxLocalLevel.TextLength > 0)
            {
                ButtonSave.Enabled = true;
            }
            else
            {
                ButtonSave.Enabled = false;
            }

            if (newLocation.LocationID > 0)
            {
                ButtonDelete.Enabled = true;
            }
            else
            {
                ButtonDelete.Enabled = false;
            }
        }
        #endregion

        #region Private Helper Methods

        private void PopulateLocations()
        {
            LocationDA locationDA = new LocationDA();
            List<Location> locations = locationDA.GetLocations();

            DataGridViewLocations.Rows.Clear();

            for (int i = 0; i < locations.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DataGridViewLocations);
                row.Cells[0].Value = Helper.GetNepaliNumber(i + 1);
                row.Cells[1].Value = locations[i].LocationPreviousVDC;
                row.Cells[2].Value = locations[i].LocationNewLevel;

                // Store location_id as Tag
                row.Tag = locations[i].LocationID.ToString();

                DataGridViewLocations.Rows.Add(row);
            }
        }

        private void ClearFields()
        {
            TextBoxLocation.Text = "";
            TextBoxLocalLevel.Text = "";
            TextBoxLocation.Focus();
        }

        private void Sanitize()
        {
            // Clear fields for new entry
            ClearFields();
            PopulateLocations();

            // Need to reset LocationID to 0 so that next time we click on Save button
            // it will not inadvertantly update the last location record instead of saving.
            newLocation.LocationID = 0;
            ButtonDelete.Enabled = false;
        }

        #endregion

    }
}
