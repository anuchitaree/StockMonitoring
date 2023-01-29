using StockMonitoring.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StockMonitoring.MiniUserControl
{
    public partial class PatternUserControl : UserControl
    {
        public PatternUserControl()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int totalletter = int.Parse(TbTotal.Text);
            int startletter = int.Parse(TbStart.Text);
            int lenletter = int.Parse(TbNumber.Text);
            string txt = TbScan.Text;
            int lentxt = txt.Length;
            if(lentxt== totalletter && (startletter+ lenletter) <= totalletter)
            {
                string result = txt.Substring(startletter, lenletter);
                TbResult.Text = result;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string data = string.Format("{0},{1},{2},{3}", TbTotal.Text, TbStart.Text, TbNumber.Text, TbScan.Text);
            string path = string.Format("{0}\\pattern.txt", Parameter.PortSetting);
            File.WriteAllText(path, data);
            Parameter.Patterns.TotalLength = int.Parse(TbTotal.Text);
            Parameter.Patterns.Start = int.Parse(TbStart.Text);
            Parameter.Patterns.Length = int.Parse(TbNumber.Text);
            MessageBox.Show("Save Completed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void PatternUserControl_Load(object sender, EventArgs e)
        {
            string path = string.Format("{0}\\pattern.txt", Parameter.PortSetting);
            if (File.Exists(path))
            {
                string data = File.ReadAllText(path);
                string[] parts = data.Split(',');
                if (parts.Length > 3)
                {
                    TbTotal.Text = parts[0];
                    TbStart.Text = parts[1];
                    TbNumber.Text = parts[2];
                    TbScan.Text = parts[3];
                }
            }
        }

        private void TbScan_TextChanged(object sender, EventArgs e)
        {
            Tblen.Text = Convert.ToString(TbScan.Text.Length);
        }
    }
}
