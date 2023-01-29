
namespace StockMonitoring.MiniUserControl
{
    partial class PatternUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatternUserControl));
            this.label1 = new System.Windows.Forms.Label();
            this.TbTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbScan = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TbResult = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Tblen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "( A ) : Total letter";
            // 
            // TbTotal
            // 
            this.TbTotal.Location = new System.Drawing.Point(155, 225);
            this.TbTotal.Name = "TbTotal";
            this.TbTotal.Size = new System.Drawing.Size(57, 23);
            this.TbTotal.TabIndex = 1;
            this.TbTotal.Text = "28";
            this.TbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "( B ) :  Start position";
            // 
            // TbStart
            // 
            this.TbStart.Location = new System.Drawing.Point(155, 253);
            this.TbStart.Name = "TbStart";
            this.TbStart.Size = new System.Drawing.Size(57, 23);
            this.TbStart.TabIndex = 1;
            this.TbStart.Text = "10";
            this.TbStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "( C ) : Number of letter";
            // 
            // TbNumber
            // 
            this.TbNumber.Location = new System.Drawing.Point(155, 280);
            this.TbNumber.Name = "TbNumber";
            this.TbNumber.Size = new System.Drawing.Size(57, 23);
            this.TbNumber.TabIndex = 1;
            this.TbNumber.Text = "15";
            this.TbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Test message";
            // 
            // TbScan
            // 
            this.TbScan.Location = new System.Drawing.Point(10, 115);
            this.TbScan.Multiline = true;
            this.TbScan.Name = "TbScan";
            this.TbScan.Size = new System.Drawing.Size(288, 74);
            this.TbScan.TabIndex = 1;
            this.TbScan.Text = "DSC1002133TG123456-45670T123";
            this.TbScan.TextChanged += new System.EventHandler(this.TbScan_TextChanged);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(218, 224);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(86, 27);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Check";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TbResult
            // 
            this.TbResult.Location = new System.Drawing.Point(60, 195);
            this.TbResult.Name = "TbResult";
            this.TbResult.ReadOnly = true;
            this.TbResult.Size = new System.Drawing.Size(238, 23);
            this.TbResult.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Result";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(218, 268);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(83, 36);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pattern part number setting";
            // 
            // Tblen
            // 
            this.Tblen.Location = new System.Drawing.Point(13, 225);
            this.Tblen.Name = "Tblen";
            this.Tblen.ReadOnly = true;
            this.Tblen.Size = new System.Drawing.Size(41, 23);
            this.Tblen.TabIndex = 5;
            this.Tblen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PatternUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tblen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TbNumber);
            this.Controls.Add(this.TbStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbResult);
            this.Controls.Add(this.TbScan);
            this.Controls.Add(this.TbTotal);
            this.Controls.Add(this.label1);
            this.Name = "PatternUserControl";
            this.Size = new System.Drawing.Size(307, 309);
            this.Load += new System.EventHandler(this.PatternUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbScan;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TbResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tblen;
    }
}
