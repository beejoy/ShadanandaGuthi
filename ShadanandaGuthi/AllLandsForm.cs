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

        private void AllLandsForm_Activated(object sender, EventArgs e)
        {
            PopulateDGVLands();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAddNewLand_Click(object sender, EventArgs e)
        {
            NewLandForm newLand = new NewLandForm();
            newLand.ShowDialog();
        }

        private void ButtonDeleteLand_Click(object sender, EventArgs e)
        {
            LandDA landDA = new LandDA();

            DataGridViewRow selectedRow = DataGridViewLands.CurrentRow;
            int landID = int.Parse(selectedRow.Tag.ToString());

            // Proceed only if the land has no lease
            if (!landDA.DoesLandHaveLease(landID))
            {
                DialogResult dlgResult;
                ConfirmationForm confirmForm = new ConfirmationForm();
                confirmForm.ConfirmationText = "के तपाई जग्गाको विवरण मेटाउन चाहनु हुन्छ ?";
                dlgResult = confirmForm.ShowDialog();
                if (dlgResult == DialogResult.OK)
                {
                    MessageForm messageForm;
                    bool result = false;

                    Land landToDelete = new Land();
                    landToDelete.LandID = landID;

                    try
                    {
                        result = landDA.DeleteLand(landToDelete);
                    }
                    catch (Exception)
                    {
                        messageForm = new MessageForm();
                        messageForm.MessageText = "आन्तरिक त्रुटीको कारण कार्य सम्पन्न गर्न सकिएन।";
                        messageForm.ShowDialog();
                    }

                    if (result)
                    {
                        messageForm = new MessageForm();
                        messageForm.MessageText = "छनौट गरिएको जग्गाको विवरण सफलतापूर्वक मेटाइयो।";
                        messageForm.ShowDialog();

                        // Refresh the datagridview
                        PopulateDGVLands();
                    }
                }
            }
        }

        private void DataGridViewLands_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = DataGridViewLands.CurrentRow;
            PopulateDGVTenants(int.Parse(selectedRow.Tag.ToString()));

            // If DataGridViewTenants has no rows, we can assume 
            // the selected land has no tenant. So we can
            // safely delete this land; so enable the Delete button

            if (DataGridViewTenants.Rows.Count > 0)
            {
                ButtonDeleteLand.Enabled = false;
            }
            else
            {
                ButtonDeleteLand.Enabled = true;
            }
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

        private void PopulateDGVTenants(int landID)
        {
            LeaseDA leaseDA = new LeaseDA();
            DataTable leasesDT = leaseDA.GetLeaseByLandID(landID);

            DataGridViewTenants.Rows.Clear();

            for (int i = 0; i <= leasesDT.Rows.Count - 1; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(DataGridViewTenants);
                row.Cells[0].Value = Helper.GetNepaliNumber(i + 1);
                row.Cells[1].Value = leasesDT.Rows[i][2];
                row.Cells[2].Value = leasesDT.Rows[i][3];
                row.Cells[3].Value = leasesDT.Rows[i][4];
                row.Cells[4].Value = leasesDT.Rows[i][5];
                row.Cells[5].Value = leasesDT.Rows[i][6];
                row.Cells[6].Value = leasesDT.Rows[i][7];
                row.Cells[7].Value = leasesDT.Rows[i][8];
                row.Cells[8].Value = leasesDT.Rows[i][9];

                // Store land_id as Tag
                row.Tag = leasesDT.Rows[i][1];

                DataGridViewTenants.Rows.Add(row);
            }
        }

    }
}
