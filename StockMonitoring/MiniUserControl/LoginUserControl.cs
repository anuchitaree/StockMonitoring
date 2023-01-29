using StockMonitoring.Classes;
using StockMonitoring.Models;
using StockMonitoring.Models.dblocal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockMonitoring.MiniUserControl
{
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void LoginUserControl_Load(object sender, EventArgs e)
        {
            string path = string.Format("{0}\\startup.txt", Parameter.PortSetting);
            if (File.Exists(path))
            {
                string str = File.ReadAllText(path);
                textBox1.Text = str.Trim();
            }
            Username.Focus();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Username.Focus();
               
            }
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
               if(Username.Text!="" && Password.Text!="") Login();
            }
        }

        private void Login()
        {
            var login = new AccountLogin();
            Parameter.User = login.Login(Username.Text, Password.Text);
            if (Parameter.User != null)
            {
                Parameter.Permition = "on";
                Parameter.SectionCode = textBox1.Text;
                BtnSubmit.Enabled = false;
                Username.Text = Password.Text = string.Empty;
                BtnSubmit.BackColor = Color.DarkSeaGreen;
                string path = string.Format("{0}\\startup.txt", Parameter.PortSetting);
                File.WriteAllText(path, textBox1.Text);
                using(var db = new WGRContext())
                {
                    var master = db.StockLists
                        .Where(s => s.SectionCode == Parameter.SectionCode)
                        .Select(s => new MasterPiece
                        {
                            PartNumberId = s.PartNumber,
                            PiecePerKanban = Convert.ToInt32(s.PiecePerKanban)
                        }).ToList();
                    Parameter.masterPieces.Clear();
                   foreach ( var m in master)
                    {
                        Parameter.masterPieces.Add(m.PartNumberId, m.PiecePerKanban);
                    }
                    if (master.Count==0)
                    {
                        string str = "No Master data, You input wrong the your SECTION-CODE \n";
                        str += "althrough you log-in sucessed,the information will NOT send to DB \n";
                        MessageBox.Show(str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Parameter.ErrorLoadFile = true;
                    }
                    else
                    {
                        Parameter.ErrorLoadFile = false;
                    }
                }

            }
            else
            {
                Password.Text = string.Empty;
                MessageBox.Show("Login Fail","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
