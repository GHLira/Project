namespace WinFormsApp10
{
    partial class frmProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProject));
            this.gpbCOD = new System.Windows.Forms.GroupBox();
            this.btoSearch = new System.Windows.Forms.Button();
            this.lblCOD = new System.Windows.Forms.Label();
            this.txtCOD = new System.Windows.Forms.TextBox();
            this.gpbCADASTRO = new System.Windows.Forms.GroupBox();
            this.mboStatus = new System.Windows.Forms.ComboBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gpbButtons = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btoCadastrar2 = new System.Windows.Forms.Button();
            this.btoDel = new System.Windows.Forms.Button();
            this.btoClean = new System.Windows.Forms.Button();
            this.btoAlterar = new System.Windows.Forms.Button();
            this.btoCadastrar = new System.Windows.Forms.Button();
            this.btoExit = new System.Windows.Forms.Button();
            this.gpbCOD.SuspendLayout();
            this.gpbCADASTRO.SuspendLayout();
            this.gpbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCOD
            // 
            this.gpbCOD.BackColor = System.Drawing.Color.Transparent;
            this.gpbCOD.Controls.Add(this.btoSearch);
            this.gpbCOD.Controls.Add(this.lblCOD);
            this.gpbCOD.Controls.Add(this.txtCOD);
            this.gpbCOD.Location = new System.Drawing.Point(34, 25);
            this.gpbCOD.Name = "gpbCOD";
            this.gpbCOD.Size = new System.Drawing.Size(513, 103);
            this.gpbCOD.TabIndex = 0;
            this.gpbCOD.TabStop = false;
            // 
            // btoSearch
            // 
            this.btoSearch.Location = new System.Drawing.Point(304, 50);
            this.btoSearch.Name = "btoSearch";
            this.btoSearch.Size = new System.Drawing.Size(31, 23);
            this.btoSearch.TabIndex = 1;
            this.btoSearch.Text = "...";
            this.btoSearch.UseVisualStyleBackColor = true;
            this.btoSearch.Click += new System.EventHandler(this.btoSearch_Click);
            // 
            // lblCOD
            // 
            this.lblCOD.AutoSize = true;
            this.lblCOD.Location = new System.Drawing.Point(20, 32);
            this.lblCOD.Name = "lblCOD";
            this.lblCOD.Size = new System.Drawing.Size(46, 15);
            this.lblCOD.TabIndex = 1;
            this.lblCOD.Text = "Código";
            // 
            // txtCOD
            // 
            this.txtCOD.Location = new System.Drawing.Point(20, 50);
            this.txtCOD.Name = "txtCOD";
            this.txtCOD.Size = new System.Drawing.Size(278, 23);
            this.txtCOD.TabIndex = 0;
            // 
            // gpbCADASTRO
            // 
            this.gpbCADASTRO.BackColor = System.Drawing.Color.Transparent;
            this.gpbCADASTRO.Controls.Add(this.mboStatus);
            this.gpbCADASTRO.Controls.Add(this.txtObs);
            this.gpbCADASTRO.Controls.Add(this.lblObs);
            this.gpbCADASTRO.Controls.Add(this.mtbCPF);
            this.gpbCADASTRO.Controls.Add(this.lblStatus);
            this.gpbCADASTRO.Controls.Add(this.lblLogin);
            this.gpbCADASTRO.Controls.Add(this.lblPassWord);
            this.gpbCADASTRO.Controls.Add(this.label1);
            this.gpbCADASTRO.Controls.Add(this.txtPW);
            this.gpbCADASTRO.Controls.Add(this.txtLogin);
            this.gpbCADASTRO.Controls.Add(this.lblName);
            this.gpbCADASTRO.Controls.Add(this.txtName);
            this.gpbCADASTRO.Location = new System.Drawing.Point(34, 144);
            this.gpbCADASTRO.Name = "gpbCADASTRO";
            this.gpbCADASTRO.Size = new System.Drawing.Size(513, 259);
            this.gpbCADASTRO.TabIndex = 1;
            this.gpbCADASTRO.TabStop = false;
            // 
            // mboStatus
            // 
            this.mboStatus.FormattingEnabled = true;
            this.mboStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.mboStatus.Location = new System.Drawing.Point(377, 99);
            this.mboStatus.Name = "mboStatus";
            this.mboStatus.Size = new System.Drawing.Size(113, 23);
            this.mboStatus.TabIndex = 6;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(20, 155);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(470, 92);
            this.txtObs.TabIndex = 7;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(20, 137);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(28, 15);
            this.lblObs.TabIndex = 12;
            this.lblObs.Text = "Obs";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(258, 99);
            this.mtbCPF.Mask = "###,###,###-##";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(113, 23);
            this.mtbCPF.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(377, 81);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 15);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(20, 81);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(37, 15);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login";
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Location = new System.Drawing.Point(139, 81);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(39, 15);
            this.lblPassWord.TabIndex = 7;
            this.lblPassWord.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "CPF";
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(139, 99);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(113, 23);
            this.txtPW.TabIndex = 4;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(20, 99);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(113, 23);
            this.txtLogin.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(20, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(470, 23);
            this.txtName.TabIndex = 2;
            // 
            // gpbButtons
            // 
            this.gpbButtons.BackColor = System.Drawing.Color.Transparent;
            this.gpbButtons.Controls.Add(this.label2);
            this.gpbButtons.Controls.Add(this.btoCadastrar2);
            this.gpbButtons.Controls.Add(this.btoDel);
            this.gpbButtons.Controls.Add(this.btoClean);
            this.gpbButtons.Controls.Add(this.btoAlterar);
            this.gpbButtons.Controls.Add(this.btoCadastrar);
            this.gpbButtons.Controls.Add(this.btoExit);
            this.gpbButtons.Location = new System.Drawing.Point(34, 407);
            this.gpbButtons.Name = "gpbButtons";
            this.gpbButtons.Size = new System.Drawing.Size(513, 67);
            this.gpbButtons.TabIndex = 2;
            this.gpbButtons.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cadastrar";
            // 
            // btoCadastrar2
            // 
            this.btoCadastrar2.BackColor = System.Drawing.Color.Gray;
            this.btoCadastrar2.Location = new System.Drawing.Point(85, 22);
            this.btoCadastrar2.Name = "btoCadastrar2";
            this.btoCadastrar2.Size = new System.Drawing.Size(41, 39);
            this.btoCadastrar2.TabIndex = 13;
            this.btoCadastrar2.Text = "2";
            this.btoCadastrar2.UseVisualStyleBackColor = false;
            this.btoCadastrar2.Click += new System.EventHandler(this.btoCadastrar2_Click);
            // 
            // btoDel
            // 
            this.btoDel.BackColor = System.Drawing.Color.Gray;
            this.btoDel.Location = new System.Drawing.Point(314, 22);
            this.btoDel.Name = "btoDel";
            this.btoDel.Size = new System.Drawing.Size(85, 39);
            this.btoDel.TabIndex = 11;
            this.btoDel.Text = "Excluir";
            this.btoDel.UseVisualStyleBackColor = false;
            this.btoDel.Click += new System.EventHandler(this.btoDel_Click);
            // 
            // btoClean
            // 
            this.btoClean.BackColor = System.Drawing.Color.Gray;
            this.btoClean.Location = new System.Drawing.Point(223, 22);
            this.btoClean.Name = "btoClean";
            this.btoClean.Size = new System.Drawing.Size(85, 39);
            this.btoClean.TabIndex = 10;
            this.btoClean.Text = "Limpar";
            this.btoClean.UseVisualStyleBackColor = false;
            this.btoClean.Click += new System.EventHandler(this.btoClean_Click);
            // 
            // btoAlterar
            // 
            this.btoAlterar.BackColor = System.Drawing.Color.Gray;
            this.btoAlterar.Location = new System.Drawing.Point(132, 22);
            this.btoAlterar.Name = "btoAlterar";
            this.btoAlterar.Size = new System.Drawing.Size(85, 39);
            this.btoAlterar.TabIndex = 9;
            this.btoAlterar.Text = "Alterar";
            this.btoAlterar.UseVisualStyleBackColor = false;
            this.btoAlterar.Click += new System.EventHandler(this.btoAlterar_Click);
            // 
            // btoCadastrar
            // 
            this.btoCadastrar.BackColor = System.Drawing.Color.Gray;
            this.btoCadastrar.Location = new System.Drawing.Point(41, 22);
            this.btoCadastrar.Name = "btoCadastrar";
            this.btoCadastrar.Size = new System.Drawing.Size(41, 39);
            this.btoCadastrar.TabIndex = 8;
            this.btoCadastrar.Text = "1";
            this.btoCadastrar.UseVisualStyleBackColor = false;
            this.btoCadastrar.Click += new System.EventHandler(this.btoCadastrar_Click);
            // 
            // btoExit
            // 
            this.btoExit.BackColor = System.Drawing.Color.Gray;
            this.btoExit.Location = new System.Drawing.Point(405, 22);
            this.btoExit.Name = "btoExit";
            this.btoExit.Size = new System.Drawing.Size(85, 39);
            this.btoExit.TabIndex = 12;
            this.btoExit.Text = "Sair";
            this.btoExit.UseVisualStyleBackColor = false;
            this.btoExit.Click += new System.EventHandler(this.btoExit_Click);
            // 
            // frmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(594, 508);
            this.Controls.Add(this.gpbButtons);
            this.Controls.Add(this.gpbCADASTRO);
            this.Controls.Add(this.gpbCOD);
            this.Name = "frmProject";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmProject_Load);
            this.gpbCOD.ResumeLayout(false);
            this.gpbCOD.PerformLayout();
            this.gpbCADASTRO.ResumeLayout(false);
            this.gpbCADASTRO.PerformLayout();
            this.gpbButtons.ResumeLayout(false);
            this.gpbButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gpbCOD;
        private Button btoSearch;
        private Label lblCOD;
        private TextBox txtCOD;
        private GroupBox gpbCADASTRO;
        private TextBox txtObs;
        private Label lblObs;
        private MaskedTextBox mtbCPF;
        private Label lblStatus;
        private Label lblLogin;
        private Label lblPassWord;
        private Label label1;
        private TextBox txtPW;
        private TextBox txtLogin;
        private Label lblName;
        private TextBox txtName;
        private GroupBox gpbButtons;
        private Button btoDel;
        private Button btoClean;
        private Button btoAlterar;
        private Button btoCadastrar;
        private Button btoExit;
        private ComboBox mboStatus;
        private Button btoCadastrar2;
        private Label label2;
    }
}