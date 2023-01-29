using StockMonitoring.Classes;
using StockMonitoring.Models;
using StockMonitoring.Models.dblocal;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StockMonitoring.MiniUserControl
{
    public partial class CRUDForm : Form
    {
        public event EventHandler CRUDClosed;
        public CRUDForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            EventHandler handler = this.CRUDClosed;
            if (handler != null)
                handler(this, EventArgs.Empty);
            this.Close();
        }

        private void CRUDForm_Load(object sender, EventArgs e)
        {
            ReadData();
        }
        private void BtnRead_Click(object sender, EventArgs e)
        {
            ReadData();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }
        private void ReadData()
        {
            try
            {
                using (var db = new WGRContext())
                {
                    var result = db.StockLists.Where(s => s.SectionCode == Parameter.SectionCode).Where(a => a.ActivePn == true).OrderBy(p=>p.PartNumber)
                                                   .Select(s => new StockListOnly
                                                   {
                                                       PartNumber = s.PartNumber,
                                                       Balance = Convert.ToInt32(s.Balance),
                                                       PiecePerKanban = Convert.ToInt32(s.PiecePerKanban),
                                                       HHLimit = Convert.ToInt32(s.Hhlimit),
                                                       HLimit = Convert.ToInt32(s.Hlimit),
                                                       LLimit = Convert.ToInt32(s.Llimit),
                                                       LLLimt = Convert.ToInt32(s.Lllimt)
                                                       
                                                   }).ToList();

                    DgvCRUD.AutoGenerateColumns = true;
                    DgvCRUD.DataSource = result;

                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void UpdateData()
        {
            using (var db = new WGRContext())
            {
                int row = DgvCRUD.CurrentRow.Index;
                var sm = new StockList();
                try
                {
                    sm.SectionCode = Parameter.SectionCode;
                    sm.PartNumber = DgvCRUD.Rows[row].Cells[0].Value.ToString();
                    sm.Balance = Convert.ToInt32(DgvCRUD.Rows[row].Cells[1].Value);
                    sm.PiecePerKanban = Convert.ToInt32(DgvCRUD.Rows[row].Cells[2].Value);
                    sm.Hhlimit = Convert.ToInt32(DgvCRUD.Rows[row].Cells[3].Value);
                    sm.Hlimit = Convert.ToInt32(DgvCRUD.Rows[row].Cells[4].Value);
                    sm.Llimit = Convert.ToInt32(DgvCRUD.Rows[row].Cells[5].Value);
                    sm.Lllimt = Convert.ToInt32(DgvCRUD.Rows[row].Cells[6].Value);
                    sm.ActivePn = true;
                    db.StockLists.Update(sm);
                    db.SaveChanges();
                    MessageBox.Show("Already saved data to dataBase.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DgvCRUDResetStlye();
                }
                catch (Exception)
                {
                    MessageBox.Show("Can not save data to dataBase ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void DeleteData()
        {
            try
            {
                using (var db = new WGRContext())
                {
                    int row = DgvCRUD.CurrentRow.Index;
                    var sm = new StockList();
                    sm.SectionCode = Parameter.SectionCode;
                    sm.PartNumber = DgvCRUD.Rows[row].Cells[0].Value.ToString();
                    sm.Balance = Convert.ToInt32(DgvCRUD.Rows[row].Cells[1].Value);
                    sm.PiecePerKanban = Convert.ToInt32(DgvCRUD.Rows[row].Cells[2].Value);
                    sm.Hhlimit = Convert.ToInt32(DgvCRUD.Rows[row].Cells[3].Value);
                    sm.Hlimit = Convert.ToInt32(DgvCRUD.Rows[row].Cells[4].Value);
                    sm.Llimit = Convert.ToInt32(DgvCRUD.Rows[row].Cells[5].Value);
                    sm.Lllimt = Convert.ToInt32(DgvCRUD.Rows[row].Cells[6].Value);
                    sm.ActivePn = true;
                    db.StockLists.Remove(sm);
                    db.SaveChanges();
                }
                MessageBox.Show("Delete Completed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void DgvCRUDResetStlye()
        {
           
            DataGridViewCellStyle styleNormal = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(255, 255, 255),
                ForeColor = Color.Black
            };
            int row = DgvCRUD.Rows.Count;
            int col = DgvCRUD.Columns.Count;

            if (row > 0)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        DgvCRUD.Rows[i].Cells[j].Style = styleNormal;
                    }
                }
              
            }
        }

        private void DgvCRUD_Click(object sender, EventArgs e)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(255, 197, 197),
                ForeColor = Color.Black
            };
            DataGridViewCellStyle styleNormal = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(255, 255, 255),
                ForeColor = Color.Black
            };
            int row = DgvCRUD.Rows.Count;
            int col = DgvCRUD.Columns.Count;

            if (row > 0)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        DgvCRUD.Rows[i].Cells[j].Style = styleNormal;
                    }
                }
                int rowc = DgvCRUD.CurrentRow.Index;
                for (int j = 0; j < col; j++)
                {
                    DgvCRUD.Rows[rowc].Cells[j].Style = style;
                }


            }
        }

        private void CRUDForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            EventHandler handler = this.CRUDClosed;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
    }

}
