namespace WinFormsApp10
{
    partial class cboID
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
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btoSearch = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.cboNcID = new System.Windows.Forms.ComboBox();
            this.cboIdCategoria = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtQntd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVlc = new System.Windows.Forms.TextBox();
            this.txtVlv = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboStats = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btoCadastro = new System.Windows.Forms.Button();
            this.btoAlterar = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoExcluir = new System.Windows.Forms.Button();
            this.btoSair = new System.Windows.Forms.Button();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cboUnidade = new System.Windows.Forms.ComboBox();
            this.gbButtons.SuspendLayout();
            this.gbCadastro.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(8, 28);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(142, 23);
            this.txtCod.TabIndex = 0;
            // 
            // btoSearch
            // 
            this.btoSearch.Location = new System.Drawing.Point(156, 28);
            this.btoSearch.Name = "btoSearch";
            this.btoSearch.Size = new System.Drawing.Size(39, 24);
            this.btoSearch.TabIndex = 1;
            this.btoSearch.Text = "...";
            this.btoSearch.UseVisualStyleBackColor = true;
            this.btoSearch.Click += new System.EventHandler(this.btoSearch_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(251, 30);
            this.txtData.Mask = "##/##/####";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(55, 23);
            this.txtData.TabIndex = 2;
            // 
            // cboNcID
            // 
            this.cboNcID.FormattingEnabled = true;
            this.cboNcID.Location = new System.Drawing.Point(343, 29);
            this.cboNcID.Name = "cboNcID";
            this.cboNcID.Size = new System.Drawing.Size(100, 23);
            this.cboNcID.TabIndex = 3;
            // 
            // cboIdCategoria
            // 
            this.cboIdCategoria.FormattingEnabled = true;
            this.cboIdCategoria.Location = new System.Drawing.Point(462, 29);
            this.cboIdCategoria.Name = "cboIdCategoria";
            this.cboIdCategoria.Size = new System.Drawing.Size(58, 23);
            this.cboIdCategoria.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(11, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 23);
            this.txtName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 15);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Nome";
            // 
            // txtQntd
            // 
            this.txtQntd.Location = new System.Drawing.Point(11, 79);
            this.txtQntd.Name = "txtQntd";
            this.txtQntd.Size = new System.Drawing.Size(260, 23);
            this.txtQntd.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantidade";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(11, 126);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(260, 23);
            this.txtPeso.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Unidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Valor de custo";
            // 
            // txtVlc
            // 
            this.txtVlc.Location = new System.Drawing.Point(277, 26);
            this.txtVlc.Name = "txtVlc";
            this.txtVlc.Size = new System.Drawing.Size(243, 23);
            this.txtVlc.TabIndex = 14;
            // 
            // txtVlv
            // 
            this.txtVlv.Location = new System.Drawing.Point(277, 79);
            this.txtVlv.Name = "txtVlv";
            this.txtVlv.Size = new System.Drawing.Size(243, 23);
            this.txtVlv.TabIndex = 15;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(277, 126);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(243, 23);
            this.txtObs.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Valor de venda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Observação";
            // 
            // cboStats
            // 
            this.cboStats.FormattingEnabled = true;
            this.cboStats.Location = new System.Drawing.Point(277, 176);
            this.cboStats.Name = "cboStats";
            this.cboStats.Size = new System.Drawing.Size(102, 23);
            this.cboStats.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Status";
            // 
            // btoCadastro
            // 
            this.btoCadastro.Location = new System.Drawing.Point(74, 18);
            this.btoCadastro.Name = "btoCadastro";
            this.btoCadastro.Size = new System.Drawing.Size(69, 33);
            this.btoCadastro.TabIndex = 21;
            this.btoCadastro.Text = "Cadastro";
            this.btoCadastro.UseVisualStyleBackColor = true;
            this.btoCadastro.Click += new System.EventHandler(this.btoCadastro_Click);
            // 
            // btoAlterar
            // 
            this.btoAlterar.Location = new System.Drawing.Point(149, 18);
            this.btoAlterar.Name = "btoAlterar";
            this.btoAlterar.Size = new System.Drawing.Size(69, 33);
            this.btoAlterar.TabIndex = 22;
            this.btoAlterar.Text = "Alterar";
            this.btoAlterar.UseVisualStyleBackColor = true;
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(224, 18);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(69, 33);
            this.btoLimpar.TabIndex = 23;
            this.btoLimpar.Text = "Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoExcluir
            // 
            this.btoExcluir.Location = new System.Drawing.Point(299, 18);
            this.btoExcluir.Name = "btoExcluir";
            this.btoExcluir.Size = new System.Drawing.Size(69, 33);
            this.btoExcluir.TabIndex = 24;
            this.btoExcluir.Text = "Excluir";
            this.btoExcluir.UseVisualStyleBackColor = true;
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(374, 18);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(69, 33);
            this.btoSair.TabIndex = 25;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.btoSair);
            this.gbButtons.Controls.Add(this.btoExcluir);
            this.gbButtons.Controls.Add(this.btoLimpar);
            this.gbButtons.Controls.Add(this.btoAlterar);
            this.gbButtons.Controls.Add(this.btoCadastro);
            this.gbButtons.Location = new System.Drawing.Point(23, 338);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(526, 65);
            this.gbButtons.TabIndex = 26;
            this.gbButtons.TabStop = false;
            // 
            // gbCadastro
            // 
            this.gbCadastro.Controls.Add(this.cboUnidade);
            this.gbCadastro.Controls.Add(this.label7);
            this.gbCadastro.Controls.Add(this.cboStats);
            this.gbCadastro.Controls.Add(this.label6);
            this.gbCadastro.Controls.Add(this.label5);
            this.gbCadastro.Controls.Add(this.txtObs);
            this.gbCadastro.Controls.Add(this.txtVlv);
            this.gbCadastro.Controls.Add(this.txtVlc);
            this.gbCadastro.Controls.Add(this.label4);
            this.gbCadastro.Controls.Add(this.label3);
            this.gbCadastro.Controls.Add(this.label2);
            this.gbCadastro.Controls.Add(this.txtPeso);
            this.gbCadastro.Controls.Add(this.label1);
            this.gbCadastro.Controls.Add(this.txtQntd);
            this.gbCadastro.Controls.Add(this.lblName);
            this.gbCadastro.Controls.Add(this.txtName);
            this.gbCadastro.Location = new System.Drawing.Point(23, 107);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(526, 213);
            this.gbCadastro.TabIndex = 27;
            this.gbCadastro.TabStop = false;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cboIdCategoria);
            this.gbSearch.Controls.Add(this.cboNcID);
            this.gbSearch.Controls.Add(this.txtData);
            this.gbSearch.Controls.Add(this.btoSearch);
            this.gbSearch.Controls.Add(this.txtCod);
            this.gbSearch.Location = new System.Drawing.Point(23, 27);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(526, 71);
            this.gbSearch.TabIndex = 28;
            this.gbSearch.TabStop = false;
            // 
            // cboUnidade
            // 
            this.cboUnidade.FormattingEnabled = true;
            this.cboUnidade.Location = new System.Drawing.Point(11, 176);
            this.cboUnidade.Name = "cboUnidade";
            this.cboUnidade.Size = new System.Drawing.Size(260, 23);
            this.cboUnidade.TabIndex = 21;
            // 
            // cboID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 415);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbCadastro);
            this.Controls.Add(this.gbButtons);
            this.Name = "cboID";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.cboID_Load);
            this.gbButtons.ResumeLayout(false);
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtCod;
        private Button btoSearch;
        private MaskedTextBox txtData;
        private ComboBox cboNcID;
        private ComboBox cboIdCategoria;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtQntd;
        private Label label1;
        private TextBox txtPeso;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtVlc;
        private TextBox txtVlv;
        private TextBox txtObs;
        private Label label5;
        private Label label6;
        private ComboBox cboStats;
        private Label label7;
        private Button btoCadastro;
        private Button btoAlterar;
        private Button btoLimpar;
        private Button btoExcluir;
        private Button btoSair;
        private GroupBox gbButtons;
        private GroupBox gbCadastro;
        private GroupBox gbSearch;
        private ComboBox cboUnidade;
    }
}