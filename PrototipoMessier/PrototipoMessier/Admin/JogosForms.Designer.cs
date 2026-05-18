namespace PrototipoMessier
{
    partial class JogosForms
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIDJogo = new TextBox();
            txtTituloJogo = new TextBox();
            txtDescricaoJogo = new TextBox();
            btnNovoJogo = new Button();
            btnSalvarJogo = new Button();
            grdJogos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewCheckBoxColumn();
            chkAtivoJogo = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)grdJogos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(142, 16);
            label1.Name = "label1";
            label1.Size = new Size(23, 16);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(57, 46);
            label2.Name = "label2";
            label2.Size = new Size(108, 16);
            label2.TabIndex = 1;
            label2.Text = "Título do Jogo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(89, 74);
            label3.Name = "label3";
            label3.Size = new Size(76, 16);
            label3.TabIndex = 2;
            label3.Text = "Descrição";
            // 
            // txtIDJogo
            // 
            txtIDJogo.BackColor = Color.White;
            txtIDJogo.BorderStyle = BorderStyle.FixedSingle;
            txtIDJogo.ForeColor = Color.Black;
            txtIDJogo.Location = new Point(171, 14);
            txtIDJogo.Margin = new Padding(3, 2, 3, 2);
            txtIDJogo.Name = "txtIDJogo";
            txtIDJogo.Size = new Size(62, 23);
            txtIDJogo.TabIndex = 0;
            // 
            // txtTituloJogo
            // 
            txtTituloJogo.BackColor = Color.White;
            txtTituloJogo.BorderStyle = BorderStyle.FixedSingle;
            txtTituloJogo.Location = new Point(171, 44);
            txtTituloJogo.Margin = new Padding(3, 2, 3, 2);
            txtTituloJogo.Name = "txtTituloJogo";
            txtTituloJogo.Size = new Size(409, 23);
            txtTituloJogo.TabIndex = 1;
            // 
            // txtDescricaoJogo
            // 
            txtDescricaoJogo.BackColor = Color.White;
            txtDescricaoJogo.BorderStyle = BorderStyle.FixedSingle;
            txtDescricaoJogo.Location = new Point(171, 72);
            txtDescricaoJogo.Margin = new Padding(3, 2, 3, 2);
            txtDescricaoJogo.Multiline = true;
            txtDescricaoJogo.Name = "txtDescricaoJogo";
            txtDescricaoJogo.Size = new Size(409, 63);
            txtDescricaoJogo.TabIndex = 2;
            // 
            // btnNovoJogo
            // 
            btnNovoJogo.BackColor = Color.White;
            btnNovoJogo.Location = new Point(259, 163);
            btnNovoJogo.Margin = new Padding(3, 2, 3, 2);
            btnNovoJogo.Name = "btnNovoJogo";
            btnNovoJogo.Size = new Size(82, 22);
            btnNovoJogo.TabIndex = 5;
            btnNovoJogo.Text = "Novo";
            btnNovoJogo.UseVisualStyleBackColor = false;
            btnNovoJogo.Click += btnNovo_Click;
            // 
            // btnSalvarJogo
            // 
            btnSalvarJogo.BackColor = Color.White;
            btnSalvarJogo.Location = new Point(171, 163);
            btnSalvarJogo.Margin = new Padding(3, 2, 3, 2);
            btnSalvarJogo.Name = "btnSalvarJogo";
            btnSalvarJogo.Size = new Size(82, 22);
            btnSalvarJogo.TabIndex = 4;
            btnSalvarJogo.Text = "Salvar";
            btnSalvarJogo.UseVisualStyleBackColor = false;
            btnSalvarJogo.Click += btnSalvar_Click;
            // 
            // grdJogos
            // 
            grdJogos.BackgroundColor = Color.DimGray;
            grdJogos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdJogos.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, Descricao, Ativo });
            grdJogos.GridColor = Color.Black;
            grdJogos.Location = new Point(41, 189);
            grdJogos.Margin = new Padding(3, 2, 3, 2);
            grdJogos.Name = "grdJogos";
            grdJogos.RowHeadersWidth = 51;
            grdJogos.Size = new Size(539, 127);
            grdJogos.TabIndex = 6;
            grdJogos.CellContentClick += grdJogos_CellContentClick;
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
            Nome.HeaderText = "Nome";
            Nome.MaxInputLength = 20;
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 200;
            // 
            // Descricao
            // 
            Descricao.HeaderText = "Descrição";
            Descricao.MaxInputLength = 200;
            Descricao.MinimumWidth = 6;
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 150;
            // 
            // Ativo
            // 
            Ativo.HeaderText = "Ativo";
            Ativo.Name = "Ativo";
            Ativo.ReadOnly = true;
            Ativo.Resizable = DataGridViewTriState.True;
            Ativo.SortMode = DataGridViewColumnSortMode.Automatic;
            Ativo.Width = 75;
            // 
            // chkAtivoJogo
            // 
            chkAtivoJogo.AutoSize = true;
            chkAtivoJogo.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkAtivoJogo.ForeColor = Color.White;
            chkAtivoJogo.Location = new Point(171, 139);
            chkAtivoJogo.Name = "chkAtivoJogo";
            chkAtivoJogo.Size = new Size(62, 20);
            chkAtivoJogo.TabIndex = 3;
            chkAtivoJogo.Text = "Ativo";
            chkAtivoJogo.UseVisualStyleBackColor = true;
            // 
            // JogosForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(613, 327);
            Controls.Add(chkAtivoJogo);
            Controls.Add(grdJogos);
            Controls.Add(btnSalvarJogo);
            Controls.Add(btnNovoJogo);
            Controls.Add(txtDescricaoJogo);
            Controls.Add(txtTituloJogo);
            Controls.Add(txtIDJogo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "JogosForms";
            Text = "Cadastro de Jogos";
            Load += JogosForms_Load;
            ((System.ComponentModel.ISupportInitialize)grdJogos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIDJogo;
        private TextBox txtTituloJogo;
        private TextBox txtDescricaoJogo;
        private Button btnNovoJogo;
        private Button btnSalvarJogo;
        private DataGridView grdJogos;
        private CheckBox chkAtivoJogo;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewCheckBoxColumn Ativo;
    }
}