using StockMonitoring.Classes;
using StockMonitoring.Models;
using System;
using System.Windows.Forms;

namespace StockMonitoring.MiniUserControl
{
    public partial class AccountUserControl : UserControl
    {
        public AccountUserControl()
        {
            InitializeComponent();
        }

        private void Repassword_TextChanged(object sender, EventArgs e)
        {
            if (Password.Text != Repassword.Text)
            {
                waring.Text = "your password incorrect";
                Btnregister.Visible = false;
            }
            else
            {
                Btnregister.Visible = true;
                waring.Text = "";
            }
        }

        private void Btnregister_Click(object sender, EventArgs e)
        {

            Registration();

        }

        private void Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Password.Focus();

            }
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Repassword.Focus();

            }
        }

        private void Repassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                Registration();
            }
        }
        private void Registration()
        {
            var account = new Account();
            account.Username = Username.Text;
            account.Password = Password.Text;
            var createaccount = new AccountLogin();
            if (account.Username != account.Password)
            {
                if (!createaccount.CreateAccount(account))
                {
                    MessageBox.Show("Exits your accout", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Username.Text = string.Empty;
                Password.Text = string.Empty;
                Repassword.Text = string.Empty;
                Btnregister.Visible = false;
                MessageBox.Show("You register completed");
            }
            else
            {
                MessageBox.Show("You input incorrect password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Username_MouseHover(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(Username.Text,out _))
            {
                MessageBox.Show("User name is numberic only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
