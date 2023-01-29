using CsvHelper;
using StockMonitoring.Models;
using StockMonitoring.Models.dblocal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace StockMonitoring.MiniUserControl
{
    public partial class StockBalanceHistory : Form
    {
        public event EventHandler StockBalanceHistoryClosed;
        List<SectionCode> Section = new List<SectionCode>();
        public StockBalanceHistory()
        {
            InitializeComponent();
        }

        private void StockBalanceHistory_Load(object sender, EventArgs e)
        {
            InitSectionCode();
        }

        private void StockBalanceHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            EventHandler handler = this.StockBalanceHistoryClosed;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            EventHandler handler = this.StockBalanceHistoryClosed;
            if (handler != null)
                handler(this, EventArgs.Empty);
            this.Close();
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            ReadDb();
        }

        private void InitSectionCode()
        {
            dateTimePicker2.Value = DateTime.Now.AddDays(1);
            IntialDataGridView(DgvHistory);

            //using (var db = new WGRContext())
            //{
            //    var Section = db.StockListLogs.GroupBy(s => s.SectionCode).Select
            //       (s => new SectionCode
            //       {
            //           Sectioncode = s.Key
            //       });
            //}


        }

        private void ReadDb()
        {
            try
            {
                CultureInfo ci = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;
                int yy = dateTimePicker1.Value.Year;
                int mm = dateTimePicker1.Value.Month;
                int dd = dateTimePicker1.Value.Day;
                DateTime dts = new DateTime(yy, mm, dd, 7, 30, 00);
                yy = dateTimePicker2.Value.Year;
                mm = dateTimePicker2.Value.Month;
                dd = dateTimePicker2.Value.Day;
                DateTime dte = new DateTime(yy, mm, dd, 7, 30, 00);
                DgvHistory.Rows.Clear();
                using (var db = new WGRContext())
                {
                    var balance = (from log in db.StockListLogs
                                   where log.Registdatetime >= dts && log.Registdatetime <= dte
                                   select new StockListLogRequest
                                   {
                                       SectionCode = log.SectionCode,
                                       Registdatetime = log.Registdatetime,
                                       PartNumber = log.PartNumber,
                                       Balance = log.Balance
                                   }).ToList();

                    //var balance = (from log in db.StockListLogs
                    //               where log.Registdatetime >= dts && log.Registdatetime <= dte
                    //               select new StockListLogRequest
                    //               {
                    //                   SectionCode = log.SectionCode,
                    //                   Registdatetime = log.Registdatetime,
                    //                   PartNumber = log.PartNumber,
                    //                   Balance = log.Balance,
                    //               }).AsEnumerable()
                    //               .Select((r,log)=>new { RowNumber = r,log }).ToList();



                   
                    int i = 1;
                    foreach (StockListLogRequest s in balance)
                    {
                        DgvHistory.Rows.Add(i, s.SectionCode, s.Registdatetime.ToString("yyyy-MM-dd HH:mm:ss"), s.PartNumber, s.Balance);
                        i++;
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            int yy = dateTimePicker1.Value.Year;
            int mm = dateTimePicker1.Value.Month;
            int dd = dateTimePicker1.Value.Day;
            DateTime dts = new DateTime(yy, mm, dd, 7, 30, 00);
            yy = dateTimePicker2.Value.Year;
            mm = dateTimePicker2.Value.Month;
            dd = dateTimePicker2.Value.Day;
            DateTime dte = new DateTime(yy, mm, dd, 7, 30, 00);

            List<StockListLogRequest> balance;
            using (var db = new WGRContext())
            {
                balance = (from log in db.StockListLogs
                           where log.Registdatetime >= dts && log.Registdatetime <= dte
                           select new StockListLogRequest
                           {
                               SectionCode = log.SectionCode,
                               Registdatetime = log.Registdatetime,
                               PartNumber = log.PartNumber,
                               Balance = log.Balance
                           }).ToList();

                //DgvHistory.AutoGenerateColumns = true;
                //DgvHistory.DataSource = balance;
            }
            List<StockListLogRequest> csvData = new List<StockListLogRequest>();
            int row = 1;
            foreach (StockListLogRequest log in balance)
            {
                var bal = new StockListLogRequest();
                bal.RowNumber = row;
                bal.SectionCode = log.SectionCode;
                bal.Registdatetime = log.Registdatetime;
                bal.PartNumber = log.PartNumber;
                bal.Balance = log.Balance;
                csvData.Add(bal);
                    row++;
            }


            string path = @"c:\MyTest.csv";


            FolderBrowserDialog folderDlg = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.Desktop,
                SelectedPath = "", // @"C:\",
                ShowNewFolderButton = true
            };
            Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = string.Format("{0}\\StockBalanceLog_{1}.csv", folderDlg.SelectedPath, DateTime.Now.ToString("yyyyMMddHHmmss"));

                using (var streamWriter = new StreamWriter(path))
                {
                    using (var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                    {
                        csvWriter.WriteRecords(csvData);
                    }
                }
            }
        }

        private void IntialDataGridView(DataGridView dataGridView2)
        {
            dataGridView2.ColumnCount = 5;
            dataGridView2.Columns[0].Name = "No";
            dataGridView2.Columns[0].Width = 40;
            dataGridView2.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[1].Name = "SectionCode";
            dataGridView2.Columns[1].Width = 70;
            dataGridView2.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[2].Name = "DateTime";
            dataGridView2.Columns[2].Width = 150;
            dataGridView2.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[3].Name = "PartNumber";
            dataGridView2.Columns[3].Width = 150;
            dataGridView2.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[4].Name = "Balance";
            dataGridView2.Columns[4].Width = 100;
            dataGridView2.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridView2.RowHeadersWidth = 4;
            dataGridView2.DefaultCellStyle.Font = new Font("Tahoma", 9);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9);
            dataGridView2.RowTemplate.Height = 30;
            dataGridView2.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 197, 197);
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
        }



    }
}
