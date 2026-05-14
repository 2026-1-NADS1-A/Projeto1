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
            txtID = new TextBox();
            txtNome = new TextBox();
            txtDescricao = new TextBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            grdJogos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewCheckBoxColumn();
            chkAtivo = new CheckBox();
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
            label1.Click += label1_Click;
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
            label2.Click += label2_Click;
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
            // txtID
            // 
            txtID.BackColor = Color.DimGray;
            txtID.Location = new Point(171, 14);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(62, 23);
            txtID.TabIndex = 3;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.DimGray;
            txtNome.Location = new Point(171, 44);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(409, 23);
            txtNome.TabIndex = 4;
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.DimGray;
            txtDescricao.Location = new Point(171, 72);
            txtDescricao.Margin = new Padding(3, 2, 3, 2);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(409, 63);
            txtDescricao.TabIndex = 5;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.White;
            btnNovo.Location = new Point(259, 163);
            btnNovo.Margin = new Padding(3, 2, 3, 2);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(82, 22);
            btnNovo.TabIndex = 6;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.White;
            btnSalvar.Location = new Point(171, 163);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 22);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
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
            grdJogos.TabIndex = 8;
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
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkAtivo.ForeColor = Color.White;
            chkAtivo.Location = new Point(171, 139);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(62, 20);
            chkAtivo.TabIndex = 9;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // JogosForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(613, 327);
            Controls.Add(chkAtivo);
            Controls.Add(grdJogos);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(txtDescricao);
            Controls.Add(txtNome);
            Controls.Add(txtID);
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
        private TextBox txtID;
        private TextBox txtNome;
        private TextBox txtDescricao;
        private Button btnNovo;
        private Button btnSalvar;
        private DataGridView grdJogos;
        private CheckBox chkAtivo;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewCheckBoxColumn Ativo;
    }
}