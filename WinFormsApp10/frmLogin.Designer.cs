namespace WinFormsApp10
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btoExit = new System.Windows.Forms.Button();
            this.btoLog = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btoExit
            // 
            this.btoExit.Location = new System.Drawing.Point(186, 128);
            this.btoExit.Name = "btoExit";
            this.btoExit.Size = new System.Drawing.Size(76, 42);
            this.btoExit.TabIndex = 11;
            this.btoExit.Text = "Sair";
            this.btoExit.UseVisualStyleBackColor = true;
            this.btoExit.Click += new System.EventHandler(this.btoExit_Click);
            // 
            // btoLog
            // 
            this.btoLog.Location = new System.Drawing.Point(104, 128);
            this.btoLog.Name = "btoLog";
            this.btoLog.Size = new System.Drawing.Size(76, 42);
            this.btoLog.TabIndex = 10;
            this.btoLog.Text = "Login";
            this.btoLog.UseVisualStyleBackColor = true;
            this.btoLog.Click += new System.EventHandler(this.btoLog_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(28, 79);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 15);
            this.lblSenha.TabIndex = 8;
            this.lblSenha.Text = "Password";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(28, 97);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(234, 23);
            this.txtSenha.TabIndex = 7;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(28, 43);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(234, 23);
            this.txtLogin.TabIndex = 6;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 197);
            this.Controls.Add(this.btoExit);
            this.Controls.Add(this.btoLog);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btoExit;
        private Button btoLog;
        private Label lblName;
        private Label lblSenha;
        private TextBox txtSenha;
        private TextBox txtLogin;
    }
}