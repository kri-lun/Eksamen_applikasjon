namespace MindfulMinutes
{
    partial class Login
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblFill = new System.Windows.Forms.Label();
            this.btnLogginn = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.lbUsername.Location = new System.Drawing.Point(144, 142);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(114, 30);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Username:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lbPassword.Location = new System.Drawing.Point(144, 204);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(108, 30);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(287, 147);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(149, 23);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(287, 213);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(149, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // lblFill
            // 
            this.lblFill.AutoSize = true;
            this.lblFill.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFill.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFill.Location = new System.Drawing.Point(74, 45);
            this.lblFill.Name = "lblFill";
            this.lblFill.Size = new System.Drawing.Size(397, 45);
            this.lblFill.TabIndex = 6;
            this.lblFill.Text = "Skriv inn logg-inn detaljer";
            // 
            // btnLogginn
            // 
            this.btnLogginn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnLogginn.BorderColor = System.Drawing.Color.Empty;
            this.btnLogginn.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogginn.FlatAppearance.BorderSize = 0;
            this.btnLogginn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogginn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogginn.ForeColor = System.Drawing.Color.White;
            this.btnLogginn.Location = new System.Drawing.Point(216, 299);
            this.btnLogginn.Name = "btnLogginn";
            this.btnLogginn.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnLogginn.OnHoverButtonColor = System.Drawing.Color.White;
            this.btnLogginn.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnLogginn.Size = new System.Drawing.Size(147, 58);
            this.btnLogginn.TabIndex = 17;
            this.btnLogginn.Text = "Logg inn";
            this.btnLogginn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnLogginn.UseVisualStyleBackColor = false;
            this.btnLogginn.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnLogginn);
            this.Controls.Add(this.lblFill);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbUsername;
        private Label lbPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ePOSOne.btnProduct.Button_WOC btnLogin;
        private ePOSOne.btnProduct.Button_WOC btnSignup;
        private Label lblFill;
        private ePOSOne.btnProduct.Button_WOC btnLogginn;
    }
}