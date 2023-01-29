
namespace StockMonitoring.MiniUserControl
{
    partial class AccountUserControl
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
            this.waring = new System.Windows.Forms.Label();
            this.Repassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.lbrepassword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnregister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // waring
            // 
            this.waring.AutoSize = true;
            this.waring.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.waring.ForeColor = System.Drawing.Color.Red;
            this.waring.Location = new System.Drawing.Point(6, 299);
            this.waring.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.waring.Name = "waring";
            this.waring.Size = new System.Drawing.Size(25, 41);
            this.waring.TabIndex = 16;
            this.waring.Text = ".";
            // 
            // Repassword
            // 
            this.Repassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Repassword.Location = new System.Drawing.Point(228, 233);
            this.Repassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Repassword.Name = "Repassword";
            this.Repassword.PasswordChar = '*';
            this.Repassword.Size = new System.Drawing.Size(182, 47);
            this.Repassword.TabIndex = 10;
            this.Repassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Repassword.TextChanged += new System.EventHandler(this.Repassword_TextChanged);
            this.Repassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Repassword_KeyPress);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(228, 160);
            this.Password.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(182, 47);
            this.Password.TabIndex = 11;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(228, 90);
            this.Username.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(182, 47);
            this.Username.TabIndex = 12;
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            this.Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Username_KeyPress);
            this.Username.MouseHover += new System.EventHandler(this.Username_MouseHover);
            // 
            // lbrepassword
            // 
            this.lbrepassword.AutoSize = true;
            this.lbrepassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbrepassword.Location = new System.Drawing.Point(45, 235);
            this.lbrepassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbrepassword.Name = "lbrepassword";
            this.lbrepassword.Size = new System.Drawing.Size(190, 41);
            this.lbrepassword.TabIndex = 13;
            this.lbrepassword.Text = "Re-password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(78, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 41);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(61, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 41);
            this.label3.TabIndex = 15;
            this.label3.Text = "User name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 72);
            this.label1.TabIndex = 17;
            this.label1.Text = "Create Account";
            // 
            // Btnregister
            // 
            this.Btnregister.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btnregister.Location = new System.Drawing.Point(228, 348);
            this.Btnregister.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Btnregister.Name = "Btnregister";
            this.Btnregister.Size = new System.Drawing.Size(156, 70);
            this.Btnregister.TabIndex = 18;
            this.Btnregister.Text = "Register";
            this.Btnregister.UseVisualStyleBackColor = true;
            this.Btnregister.Visible = false;
            this.Btnregister.Click += new System.EventHandler(this.Btnregister_Click);
            // 
            // AccountUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btnregister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waring);
            this.Controls.Add(this.Repassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.lbrepassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AccountUserControl";
            this.Size = new System.Drawing.Size(436, 427);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label waring;
        private System.Windows.Forms.TextBox Repassword;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label lbrepassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnregister;
    }
}
