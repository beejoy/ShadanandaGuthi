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
    public partial class MessageForm : Form
    {
        public string MessageText { get; set; }

        public MessageForm()
        {
            InitializeComponent();
        }

        public MessageForm(string messageText)
        {
            MessageText = messageText;
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            LabelMessage.Text = MessageText;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
