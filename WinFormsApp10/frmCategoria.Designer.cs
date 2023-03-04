namespace WinFormsApp10
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            this.btoCad = new System.Windows.Forms.Button();
            this.btoAlter = new System.Windows.Forms.Button();
            this.btoClean = new System.Windows.Forms.Button();
            this.btoExcl = new System.Windows.Forms.Button();
            this.btoExit = new System.Windows.Forms.Button();
            this.gpbButton = new System.Windows.Forms.GroupBox();
            this.gpbCad = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.btoSearch = new System.Windows.Forms.Button();
            this.cboStats = new System.Windows.Forms.ComboBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbButton.SuspendLayout();
            this.gpbCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btoCad
            // 
            this.btoCad.Location = new System.Drawing.Point(11, 15);
            this.btoCad.Name = "btoCad";
            this.btoCad.Size = new System.Drawing.Size(86, 46);
            this.btoCad.TabIndex = 0;
            this.btoCad.Text = "Cadastrar";
            this.btoCad.UseVisualStyleBackColor = true;
            this.btoCad.Click += new System.EventHandler(this.btoCad_Click);
            // 
            // btoAlter
            // 
            this.btoAlter.Location = new System.Drawing.Point(103, 15);
            this.btoAlter.Name = "btoAlter";
            this.btoAlter.Size = new System.Drawing.Size(86, 46);
            this.btoAlter.TabIndex = 1;
            this.btoAlter.Text = "Alterar";
            this.btoAlter.UseVisualStyleBackColor = true;
            this.btoAlter.Click += new System.EventHandler(this.btoAlter_Click);
            // 
            // btoClean
            // 
            this.btoClean.Location = new System.Drawing.Point(195, 15);
            this.btoClean.Name = "btoClean";
            this.btoClean.Size = new System.Drawing.Size(86, 46);
            this.btoClean.TabIndex = 2;
            this.btoClean.Text = "Limpar";
            this.btoClean.UseVisualStyleBackColor = true;
            this.btoClean.Click += new System.EventHandler(this.btoClean_Click);
            // 
            // btoExcl
            // 
            this.btoExcl.Location = new System.Drawing.Point(287, 15);
            this.btoExcl.Name = "btoExcl";
            this.btoExcl.Size = new System.Drawing.Size(86, 46);
            this.btoExcl.TabIndex = 3;
            this.btoExcl.Text = "Excluir";
            this.btoExcl.UseVisualStyleBackColor = true;
            this.btoExcl.Click += new System.EventHandler(this.btoExcl_Click);
            // 
            // btoExit
            // 
            this.btoExit.Location = new System.Drawing.Point(379, 15);
            this.btoExit.Name = "btoExit";
            this.btoExit.Size = new System.Drawing.Size(86, 46);
            this.btoExit.TabIndex = 4;
            this.btoExit.Text = "Sair";
            this.btoExit.UseVisualStyleBackColor = true;
            this.btoExit.Click += new System.EventHandler(this.btoExit_Click);
            // 
            // gpbButton
            // 
            this.gpbButton.BackColor = System.Drawing.Color.Transparent;
            this.gpbButton.Controls.Add(this.btoExit);
            this.gpbButton.Controls.Add(this.btoExcl);
            this.gpbButton.Controls.Add(this.btoClean);
            this.gpbButton.Controls.Add(this.btoAlter);
            this.gpbButton.Controls.Add(this.btoCad);
            this.gpbButton.Location = new System.Drawing.Point(12, 345);
            this.gpbButton.Name = "gpbButton";
            this.gpbButton.Size = new System.Drawing.Size(471, 70);
            this.gpbButton.TabIndex = 5;
            this.gpbButton.TabStop = false;
            // 
            // gpbCad
            // 
            this.gpbCad.BackColor = System.Drawing.Color.Transparent;
            this.gpbCad.Controls.Add(this.label4);
            this.gpbCad.Controls.Add(this.label3);
            this.gpbCad.Controls.Add(this.label2);
            this.gpbCad.Controls.Add(this.lblObs);
            this.gpbCad.Controls.Add(this.btoSearch);
            this.gpbCad.Controls.Add(this.cboStats);
            this.gpbCad.Controls.Add(this.txtObs);
            this.gpbCad.Controls.Add(this.txtName);
            this.gpbCad.Controls.Add(this.txtDescription);
            this.gpbCad.Controls.Add(this.txtCod);
            this.gpbCad.Location = new System.Drawing.Point(23, 95);
            this.gpbCad.Name = "gpbCad";
            this.gpbCad.Size = new System.Drawing.Size(454, 234);
            this.gpbCad.TabIndex = 6;
            this.gpbCad.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(408, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(408, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descrição";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.BackColor = System.Drawing.Color.White;
            this.lblObs.Location = new System.Drawing.Point(6, 123);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(28, 15);
            this.lblObs.TabIndex = 7;
            this.lblObs.Text = "Obs";
            // 
            // btoSearch
            // 
            this.btoSearch.Location = new System.Drawing.Point(411, 36);
            this.btoSearch.Name = "btoSearch";
            this.btoSearch.Size = new System.Drawing.Size(37, 23);
            this.btoSearch.TabIndex = 6;
            this.btoSearch.Text = "...";
            this.btoSearch.UseVisualStyleBackColor = true;
            this.btoSearch.Click += new System.EventHandler(this.btoSearch_Click);
            // 
            // cboStats
            // 
            this.cboStats.FormattingEnabled = true;
            this.cboStats.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cboStats.Location = new System.Drawing.Point(344, 153);
            this.cboStats.Name = "cboStats";
            this.cboStats.Size = new System.Drawing.Size(104, 23);
            this.cboStats.TabIndex = 5;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(6, 141);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(181, 84);
            this.txtObs.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(193, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(255, 23);
            this.txtName.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 37);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(181, 83);
            this.txtDescription.TabIndex = 1;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(193, 37);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(212, 23);
            this.txtCod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(153, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "CATEGORIA";
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(506, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbCad);
            this.Controls.Add(this.gpbButton);
            this.Name = "frmCategoria";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbButton.ResumeLayout(false);
            this.gpbCad.ResumeLayout(false);
            this.gpbCad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btoCad;
        private Button btoAlter;
        private Button btoClean;
        private Button btoExcl;
        private Button btoExit;
        private GroupBox gpbButton;
        private GroupBox gpbCad;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblObs;
        private Button btoSearch;
        private ComboBox cboStats;
        private TextBox txtObs;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtCod;
        private Label label1;
    }
}