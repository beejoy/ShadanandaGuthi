using System;
using System.Windows.Forms;
using ShadanandaGuthiLibrary;
using ShadanandaGuthiLibrary.DataAccess;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthi
{
    public partial class CurrentYearForm : Form
    {
        public CurrentYearForm()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateRentYears()
        {
            RentYearDA rentYearDA = new RentYearDA();

            ListBoxCurrentYear.DataSource = rentYearDA.GetAllRentYears();
            ListBoxCurrentYear.DisplayMember = "TheRentYear";
            ListBoxCurrentYear.ValueMember = "YearID";
        }

        private void CurrentYearForm_Activated(object sender, EventArgs e)
        {
            PopulateRentYears();
        }

        private void ButtonAddNewYear_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the topmost year in the listbox
                RentYear lastYear = (RentYear)ListBoxCurrentYear.Items[0];

                // Pass it to helper function and get the next higher year
                string npYear = lastYear.TheRentYear.ToString();

                RentYearDA rentYearDA = new RentYearDA();
                RentYear newRentYear = new RentYear();
                newRentYear.TheRentYear = Helper.GetNextYear(npYear);

                rentYearDA.SaveRentYear(newRentYear);
            }
            catch (Exception)
            {
                MessageForm messageForm = new MessageForm();
                messageForm.MessageText = "प्राविधिक कारणले गर्दा नयाँ वर्ष थप गर्न सकिएन।";
                messageForm.ShowDialog();
            }

            PopulateRentYears();
        }

        private void ButtonDeleteYear_Click(object sender, EventArgs e)
        {
            MessageForm messageForm = new MessageForm();

            // We won't let the user delete all the years;
            // there must be at least one year in the list
            if (ListBoxCurrentYear.Items.Count > 1)
            {
                // Get the topmost year in the listbox
                RentYear selectedYear = (RentYear)ListBoxCurrentYear.Items[ListBoxCurrentYear.SelectedIndex];

                // Pass it to helper function and get the next higher year
                string npYear = selectedYear.TheRentYear.ToString();

                RentYearDA rentYearDA = new RentYearDA();
                
                if (rentYearDA.DoesRentYearHaveLeasePayment(selectedYear))
                {
                    messageForm.MessageText = "उक्त वर्षमा ठेक्का तिरेको रेकर्ड भएको कारणले गर्दा मेटाउन सकिएन।";
                    messageForm.ShowDialog();
                }
                else
                {
                    bool success = rentYearDA.DeleteRentYear(selectedYear);
                    if (!success)
                    {
                        messageForm.MessageText = "प्राविधिक कारणले गर्दा मेटाउन सकिएन।";
                        messageForm.ShowDialog();
                    }
                }

                PopulateRentYears();
            }
            else
            {
                messageForm.MessageText = "माफ गर्नुहोला, सूचीबाट सबै वर्ष मेटाउन सकिंदैन।";
                messageForm.ShowDialog();
            }
        }
    }
}
