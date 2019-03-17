using System;
using System.Windows.Forms;
using ShadanandaGuthiLibrary.DataAccess;
using ShadanandaGuthiLibrary.Model;

namespace ShadanandaGuthi
{
    public partial class LoginForm : Form
    {
        LoginUser loginUser;

        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(LoginUser user)
        {
            InitializeComponent();
            loginUser = user;
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            //if(loginUser.Username=="" || loginUser.Password=="")
            //{
            //    MessageBox.Show("Login failed!!!");
            //}
            //else
            //{
            //    LoginUserDA loginDA = new LoginUserDA();

            //    if (loginDA.VerifyLogin(loginUser))
            //    {
            //        this.Close();
            //    }
            //}
        }

        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {
            loginUser.Username = TextBoxUsername.Text;
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            loginUser.Password = TextBoxPassword.Text;
        }
    }
}
