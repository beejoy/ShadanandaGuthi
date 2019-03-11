using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ShadanandaGuthiLibrary;
using ShadanandaGuthiLibrary.DataAccess;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthi
{
    public partial class AllLandsForm : Form
    {
        public AllLandsForm()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateDGVLands()
        {
            LandDA landDA = new LandDA();
            List<Land> lands = landDA.GetLands();

            DataGridViewLands.Rows.Clear();

            int i = 0;

            while (i < lands.Count)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DataGridViewLands);
                row.Cells[0].Value = Helper.GetNepaliNumber(i + 1);
                row.Cells[1].Value = lands[i].LandLocation.LocationPreviousVDC;
                row.Cells[2].Value = lands[i].PlotNumber;
                row.Cells[3].Value = lands[i].LandArea;

                // Store land_id as Tag
                row.Tag = lands[i].LandID.ToString();

                DataGridViewLands.Rows.Add(row);
                i++;
            }
        }

        private void AllLandsForm_Activated(object sender, EventArgs e)
        {
            PopulateDGVLands();
        }

        private void DataGridViewLands_SelectionChanged(object sender, EventArgs e)
        {
            LeaseDA leaseDA = new LeaseDA();

            DataGridViewRow selectedRow = DataGridViewLands.CurrentRow;
            DataTable leasesDT = leaseDA.GetLeaseByLandID(int.Parse(selectedRow.Tag.ToString()), true);

            DataGridViewTenants.Rows.Clear();

            //int i = 0;

            for ( int i =0; i <= leasesDT.Rows.Count-1; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                //DataRow dataRow = leasesDT.Rows[i];

                row.CreateCells(DataGridViewTenants);
                row.Cells[0].Value = Helper.GetNepaliNumber(i + 1);
                row.Cells[1].Value = leasesDT.Rows[i][2];
                row.Cells[2].Value = leasesDT.Rows[i][3];
                row.Cells[3].Value = leasesDT.Rows[i][4];
                row.Cells[4].Value = leasesDT.Rows[i][5];
                row.Cells[5].Value = leasesDT.Rows[i][6];
                row.Cells[6].Value = leasesDT.Rows[i][7];
                row.Cells[7].Value = leasesDT.Rows[i][8];

                // Store land_id as Tag
                row.Tag = leasesDT.Rows[i][1];

                DataGridViewTenants.Rows.Add(row);
                //i++;
            }
        }

        private void ButtonAddNewLand_Click(object sender, EventArgs e)
        {
            NewLandForm newLand = new NewLandForm();
            newLand.ShowDialog();
        }
    }
}
