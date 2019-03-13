using System;
using System.Windows.Forms;
using ShadanandaGuthiLibrary.DataAccess;

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

            ListBoxCurrentYear.Items.Clear();

            ListBoxCurrentYear.DataSource = rentYearDA.GetAllRentYears();
            ListBoxCurrentYear.DisplayMember = "TheRentYear";
            ListBoxCurrentYear.ValueMember = "YearID";
        }

        private void CurrentYearForm_Activated(object sender, EventArgs e)
        {
            PopulateRentYears();
        }
    }
}
