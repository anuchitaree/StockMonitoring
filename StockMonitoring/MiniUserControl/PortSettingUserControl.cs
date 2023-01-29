using StockMonitoring.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace StockMonitoring.MiniUserControl
{
    public partial class PortSettingUserControl : UserControl
    {
        readonly string no;
        public PortSettingUserControl(string no)
        {
            InitializeComponent();
            this.no = no;
        }


        private void PortSettingUserControl_Load(object sender, EventArgs e)
        {
            COMPort();
            LoadSettingfile();
            lbname.Text = string.Format("Channel {0} Setup", no);
        }


        private void COMPort()
        {
            for (int i = 1; i < 20; i++)
            {
                string str = string.Format("COM{0}", i);
                CmbCom.Items.Add(str);
            }
            CmbCom.SelectedIndex = 0;
            string[] baudrate = new string[] { "300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "230400", "460800", "921600" };
            string[] parity = new string[] { "None", "Even", "Odd" };
            string[] lenght = new string[] { "7", "8", "9" };
            string[] stopbit = new string[] { "1", "1.5", "2" };
            string[] direction = new string[] { "IN", "OUT" };
            CmbBaudRate.DataSource = baudrate;
            CmbParity.DataSource = parity;
            CmbDatalength.DataSource = lenght;
            CmbStopBit.DataSource = stopbit;
            CmbDatDirection.DataSource = direction;
        }

        private void LoadSettingfile()
        {
            string path = string.Format("{0}\\PortSetting{1}.txt", Parameter.PortSetting, no);
            if (File.Exists(path))
            {
                string data = File.ReadAllText(path);
                string[] parts = data.Split(',');
                if (parts.Length == 6)
                {
                    string comport = parts[0];
                    string baudrate = parts[1];
                    string parity = parts[2];
                    string dataBits = parts[3];
                    string stopbit = parts[4];
                    string direction = parts[5];

                    CmbCom.SelectedItem = comport;
                    CmbBaudRate.SelectedItem = baudrate;
                    CmbParity.SelectedItem = parity;
                    CmbDatalength.SelectedItem = dataBits;
                    CmbStopBit.SelectedItem = stopbit;
                    CmbDatDirection.SelectedItem = direction;
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

                List<string> com = new List<string>();
                for (int i = 1; i < 5; i++)
                {
                    string checkpath = string.Format("{0}\\PortSetting{1}.txt", Parameter.PortSetting, i);
                    string[] part = File.ReadAllText(checkpath).Split(',');
                    com.Add(part[0]);
                }
                com.RemoveAt(Convert.ToInt32(no) - 1);
                if (!com.Contains(CmbCom.SelectedItem.ToString()))
                {
                    string setting = string.Format("{0},{1},{2},{3},{4},{5}", CmbCom.SelectedItem, CmbBaudRate.SelectedItem, CmbParity.SelectedItem,
                   CmbDatalength.SelectedItem, CmbStopBit.SelectedItem, CmbDatDirection.SelectedItem);
                    string path = string.Format("{0}\\PortSetting{1}.txt", Parameter.PortSetting, no);
                    File.WriteAllTextAsync(path, setting);
                    MessageBox.Show("Save setting Completed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string str = string.Format($"COM Port : {CmbCom.SelectedItem} was used in another channel");
                    MessageBox.Show(str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

                MessageBox.Show("Error Save setting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
