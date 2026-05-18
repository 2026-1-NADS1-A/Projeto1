namespace PrototipoMessier
{
    partial class PacoteForms
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
            txtNomePacote = new TextBox();
            txtIDPacote = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            chkPacote = new CheckedListBox();
            grdPacotes = new DataGridView();
            btnSalvarPacote = new Button();
            btnNovoPacote = new Button();
            lblLimite = new Label();
            nudLimite = new NumericUpDown();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            limiteMensal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grdPacotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLimite).BeginInit();
            SuspendLayout();
            // 
            // txtNomePacote
            // 
            txtNomePacote.BackColor = Color.White;
            txtNomePacote.BorderStyle = BorderStyle.FixedSingle;
            txtNomePacote.Location = new Point(171, 44);
            txtNomePacote.Margin = new Padding(3, 2, 3, 2);
            txtNomePacote.Name = "txtNomePacote";
            txtNomePacote.Size = new Size(409, 23);
            txtNomePacote.TabIndex = 1;
            // 
            // txtIDPacote
            // 
            txtIDPacote.BackColor = Color.White;
            txtIDPacote.BorderStyle = BorderStyle.FixedSingle;
            txtIDPacote.ForeColor = Color.Black;
            txtIDPacote.Location = new Point(171, 14);
            txtIDPacote.Margin = new Padding(3, 2, 3, 2);
            txtIDPacote.Name = "txtIDPacote";
            txtIDPacote.Size = new Size(62, 23);
            txtIDPacote.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(41, 46);
            label2.Name = "label2";
            label2.Size = new Size(124, 16);
            label2.TabIndex = 6;
            label2.Text = "Nome do Pacote";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(142, 16);
            label1.Name = "label1";
            label1.Size = new Size(23, 16);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 72);
            label3.Name = "label3";
            label3.Size = new Size(125, 16);
            label3.TabIndex = 9;
            label3.Text = "Jogos do Pacote";
            // 
            // chkPacote
            // 
            chkPacote.BackColor = Color.White;
            chkPacote.BorderStyle = BorderStyle.FixedSingle;
            chkPacote.FormattingEnabled = true;
            chkPacote.Location = new Point(171, 72);
            chkPacote.Margin = new Padding(3, 2, 3, 2);
            chkPacote.Name = "chkPacote";
            chkPacote.Size = new Size(252, 74);
            chkPacote.TabIndex = 2;
            // 
            // grdPacotes
            // 
            grdPacotes.BackgroundColor = Color.DimGray;
            grdPacotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPacotes.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, limiteMensal });
            grdPacotes.GridColor = Color.Black;
            grdPacotes.Location = new Point(41, 189);
            grdPacotes.Margin = new Padding(3, 2, 3, 2);
            grdPacotes.Name = "grdPacotes";
            grdPacotes.RowHeadersWidth = 51;
            grdPacotes.ScrollBars = ScrollBars.Vertical;
            grdPacotes.Size = new Size(539, 127);
            grdPacotes.TabIndex = 5;
            // 
            // btnSalvarPacote
            // 
            btnSalvarPacote.Location = new Point(171, 163);
            btnSalvarPacote.Margin = new Padding(3, 2, 3, 2);
            btnSalvarPacote.Name = "btnSalvarPacote";
            btnSalvarPacote.Size = new Size(82, 22);
            btnSalvarPacote.TabIndex = 3;
            btnSalvarPacote.Text = "Salvar";
            btnSalvarPacote.UseVisualStyleBackColor = true;
            btnSalvarPacote.Click += btnSalvar_Click;
            // 
            // btnNovoPacote
            // 
            btnNovoPacote.Location = new Point(259, 163);
            btnNovoPacote.Margin = new Padding(3, 2, 3, 2);
            btnNovoPacote.Name = "btnNovoPacote";
            btnNovoPacote.Size = new Size(82, 22);
            btnNovoPacote.TabIndex = 4;
            btnNovoPacote.Text = "Novo";
            btnNovoPacote.UseVisualStyleBackColor = true;
            btnNovoPacote.Click += btnNovo_Click;
            // 
            // lblLimite
            // 
            lblLimite.AutoSize = true;
            lblLimite.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLimite.ForeColor = Color.White;
            lblLimite.Location = new Point(451, 72);
            lblLimite.Name = "lblLimite";
            lblLimite.Size = new Size(105, 16);
            lblLimite.TabIndex = 10;
            lblLimite.Text = "Limite Mensal";
            // 
            // nudLimite
            // 
            nudLimite.Location = new Point(451, 91);
            nudLimite.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudLimite.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudLimite.Name = "nudLimite";
            nudLimite.Size = new Size(100, 23);
            nudLimite.TabIndex = 12;
            nudLimite.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MaxInputLength = 3;
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 60;
            // 
            // Nome
            // 
            Nome.HeaderText = "Pacote";
            Nome.MaxInputLength = 20;
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 150;
            // 
            // limiteMensal
            // 
            limiteMensal.HeaderText = "Limite Mensal";
            limiteMensal.MaxInputLength = 3;
            limiteMensal.Name = "limiteMensal";
            limiteMensal.Width = 150;
            // 
            // PacoteForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(613, 327);
            Controls.Add(nudLimite);
            Controls.Add(lblLimite);
            Controls.Add(btnSalvarPacote);
            Controls.Add(btnNovoPacote);
            Controls.Add(grdPacotes);
            Controls.Add(chkPacote);
            Controls.Add(label3);
            Controls.Add(txtNomePacote);
            Controls.Add(txtIDPacote);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PacoteForms";
            Text = "Cadastro de Pacotes";
            ((System.ComponentModel.ISupportInitialize)grdPacotes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLimite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomePacote;
        private TextBox txtIDPacote;
        private Label label2;
        private Label label1;
        private Label label3;
        private CheckedListBox chkPacote;
        private DataGridView grdPacotes;
        private Button btnSalvarPacote;
        private Button btnNovoPacote;
        private Label lblLimite;
        private NumericUpDown nudLimite;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn limiteMensal;
    }
}