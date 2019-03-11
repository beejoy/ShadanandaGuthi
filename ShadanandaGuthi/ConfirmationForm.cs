using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadanandaGuthi
{
    public partial class ConfirmationForm : Form
    {
        public string ConfirmationText { get; set; }

        public ConfirmationForm()
        {
            InitializeComponent();
        }

        public ConfirmationForm(string confirmationText)
        {
            ConfirmationText = confirmationText;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmationForm_Load(object sender, EventArgs e)
        {
            LabelConfirmationText.Text = ConfirmationText;
        }
    }
}
