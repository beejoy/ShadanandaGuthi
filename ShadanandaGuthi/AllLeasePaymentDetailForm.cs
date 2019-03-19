using System;
using System.Data;
using System.Windows.Forms;
using ShadanandaGuthiLibrary;
using ShadanandaGuthiLibrary.DataAccess;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthi
{
    public partial class AllLeasePaymentDetailForm : Form
    {
        public AllLeasePaymentDetailForm()
        {
            InitializeComponent();
        }

        private void AllLeasePaymentDetailForm_Load(object sender, EventArgs e)
        {
            PopulateRentYears();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxRentYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Retrieve the RentYearID
            //RentYear selectedRentYear = (RentYear)ComboBoxRentYear.SelectedItem;
            //int rentYearID = selectedRentYear.YearID;
            UpdatePaymentDetails();

        }

        private void PopulateRentYears()
        {
            RentYearDA rentYearDA = new RentYearDA();

            ComboBoxRentYear.DataSource = rentYearDA.GetAllRentYears();
            ComboBoxRentYear.DisplayMember = "TheRentYear";
            ComboBoxRentYear.ValueMember = "YearID";
        }

        private void UpdatePaymentDetails()
        {
            DataGridViewPaymentDetails.Rows.Clear();

            // Retrieve the RentYearID
            RentYear selectedRentYear = (RentYear)ComboBoxRentYear.SelectedItem;
            int rentYearID = selectedRentYear.YearID;

            // Retrieve records of LeasePayment for TenantID for RentYearID
            LeasePaymentDA paymentDA = new LeasePaymentDA();
            DataTable paymentDetailsDT = paymentDA.GetAllPaymentDetailsByRentYearID(rentYearID);

            DataGridViewPaymentDetails.Rows.Clear();

            for (int i = 0; i <= paymentDetailsDT.Rows.Count - 1; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(DataGridViewPaymentDetails);
                row.Cells[0].Value = Helper.GetNepaliNumber(i + 1);
                row.Cells[1].Value = paymentDetailsDT.Rows[i][0];
                row.Cells[2].Value = paymentDetailsDT.Rows[i][1];
                row.Cells[3].Value = paymentDetailsDT.Rows[i][2];
                row.Cells[4].Value = paymentDetailsDT.Rows[i][3];
                row.Cells[5].Value = paymentDetailsDT.Rows[i][5];
                row.Cells[6].Value = paymentDetailsDT.Rows[i][6];
                row.Cells[7].Value = paymentDetailsDT.Rows[i][7];
                row.Cells[8].Value = paymentDetailsDT.Rows[i][8];

                // Store land_id as Tag
                row.Tag = paymentDetailsDT.Rows[i][1];

                DataGridViewPaymentDetails.Rows.Add(row);
            }
        }

    }
}
