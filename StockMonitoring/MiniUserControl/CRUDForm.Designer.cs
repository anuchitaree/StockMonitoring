
namespace StockMonitoring.MiniUserControl
{
    partial class CRUDForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnClose = new System.Windows.Forms.Button();
            this.DgvCRUD = new System.Windows.Forms.DataGridView();
            this.BtnRead = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCRUD)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(788, 543);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 51);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // DgvCRUD
            // 
            this.DgvCRUD.AllowUserToDeleteRows = false;
            this.DgvCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCRUD.Location = new System.Drawing.Point(-3, 2);
            this.DgvCRUD.Name = "DgvCRUD";
            this.DgvCRUD.RowTemplate.Height = 25;
            this.DgvCRUD.Size = new System.Drawing.Size(785, 592);
            this.DgvCRUD.TabIndex = 1;
            this.DgvCRUD.Click += new System.EventHandler(this.DgvCRUD_Click);
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(788, 2);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(75, 42);
            this.BtnRead.TabIndex = 2;
            this.BtnRead.Text = "Refresh";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(787, 73);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 42);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Save";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(787, 144);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 42);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // CRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 598);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.DgvCRUD);
            this.Controls.Add(this.BtnClose);
            this.MaximizeBox = false;
            this.Name = "CRUDForm";
            this.Text = "Edit and Delete data";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CRUDForm_FormClosed);
            this.Load += new System.EventHandler(this.CRUDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCRUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView DgvCRUD;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
    }
}