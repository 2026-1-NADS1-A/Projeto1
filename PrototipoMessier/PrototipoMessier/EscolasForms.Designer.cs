namespace PrototipoMessier
{
    partial class EscolasForms
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
            txtCnpj = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtInstituicao = new TextBox();
            txtIP = new TextBox();
            grdEscolas = new DataGridView();
            chkPacote = new CheckedListBox();
            btnSalvar = new Button();
            btnNovo = new Button();
            CNPJ = new DataGridViewTextBoxColumn();
            NomeInstituição = new DataGridViewTextBoxColumn();
            Pacote = new DataGridViewTextBoxColumn();
            IP = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grdEscolas).BeginInit();
            SuspendLayout();
            // 
            // txtCnpj
            // 
            txtCnpj.BackColor = Color.DimGray;
            txtCnpj.Location = new Point(171, 14);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(157, 23);
            txtCnpj.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(123, 16);
            label1.Name = "label1";
            label1.Size = new Size(42, 16);
            label1.TabIndex = 1;
            label1.Text = "CNPJ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 46);
            label2.Name = "label2";
            label2.Size = new Size(152, 16);
            label2.TabIndex = 2;
            label2.Text = "Nome da Instituição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(143, 156);
            label3.Name = "label3";
            label3.Size = new Size(22, 16);
            label3.TabIndex = 3;
            label3.Text = "IP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(109, 73);
            label4.Name = "label4";
            label4.Size = new Size(56, 16);
            label4.TabIndex = 4;
            label4.Text = "Pacote";
            // 
            // txtInstituicao
            // 
            txtInstituicao.BackColor = Color.DimGray;
            txtInstituicao.Location = new Point(171, 44);
            txtInstituicao.Name = "txtInstituicao";
            txtInstituicao.Size = new Size(157, 23);
            txtInstituicao.TabIndex = 5;
            // 
            // txtIP
            // 
            txtIP.BackColor = Color.DimGray;
            txtIP.Location = new Point(171, 156);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(157, 23);
            txtIP.TabIndex = 7;
            // 
            // grdEscolas
            // 
            grdEscolas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdEscolas.Columns.AddRange(new DataGridViewColumn[] { CNPJ, NomeInstituição, Pacote, IP });
            grdEscolas.Location = new Point(41, 189);
            grdEscolas.Name = "grdEscolas";
            grdEscolas.Size = new Size(539, 127);
            grdEscolas.TabIndex = 8;
            grdEscolas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // chkPacote
            // 
            chkPacote.BackColor = Color.DimGray;
            chkPacote.FormattingEnabled = true;
            chkPacote.Items.AddRange(new object[] { "Bronze", "Prata", "Ouro", "Personalizado" });
            chkPacote.Location = new Point(171, 73);
            chkPacote.Name = "chkPacote";
            chkPacote.Size = new Size(157, 76);
            chkPacote.TabIndex = 9;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(397, 157);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 22);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(498, 157);
            btnNovo.Margin = new Padding(3, 2, 3, 2);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(82, 22);
            btnNovo.TabIndex = 15;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // CNPJ
            // 
            CNPJ.HeaderText = "CNPJ";
            CNPJ.MaxInputLength = 14;
            CNPJ.Name = "CNPJ";
            CNPJ.Width = 121;
            // 
            // NomeInstituição
            // 
            NomeInstituição.HeaderText = "Instituição";
            NomeInstituição.MaxInputLength = 100;
            NomeInstituição.Name = "NomeInstituição";
            NomeInstituição.Width = 150;
            // 
            // Pacote
            // 
            Pacote.HeaderText = "Pacote";
            Pacote.MaxInputLength = 15;
            Pacote.Name = "Pacote";
            // 
            // IP
            // 
            IP.HeaderText = "IP";
            IP.MaxInputLength = 15;
            IP.Name = "IP";
            IP.Width = 125;
            // 
            // EscolasForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(613, 327);
            Controls.Add(btnNovo);
            Controls.Add(btnSalvar);
            Controls.Add(chkPacote);
            Controls.Add(grdEscolas);
            Controls.Add(txtIP);
            Controls.Add(txtInstituicao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCnpj);
            Name = "EscolasForms";
            Text = "EscolasForms";
            ((System.ComponentModel.ISupportInitialize)grdEscolas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCnpj;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtInstituicao;
        private TextBox txtIP;
        private DataGridView grdEscolas;
        private CheckedListBox chkPacote;
        private Button btnSalvar;
        private Button btnNovo;
        private DataGridViewTextBoxColumn CNPJ;
        private DataGridViewTextBoxColumn NomeInstituição;
        private DataGridViewTextBoxColumn Pacote;
        private DataGridViewTextBoxColumn IP;
    }
}