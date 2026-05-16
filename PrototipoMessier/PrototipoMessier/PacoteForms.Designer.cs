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
            txtNome = new TextBox();
            txtID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            checkedListBox1 = new CheckedListBox();
            grdPacotes = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            btnSalvar = new Button();
            btnNovo = new Button();
            ((System.ComponentModel.ISupportInitialize)grdPacotes).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(171, 44);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(409, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtID
            // 
            txtID.BackColor = Color.White;
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.ForeColor = Color.Black;
            txtID.Location = new Point(171, 14);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(62, 23);
            txtID.TabIndex = 0;
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
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.White;
            checkedListBox1.BorderStyle = BorderStyle.FixedSingle;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(171, 72);
            checkedListBox1.Margin = new Padding(3, 2, 3, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(252, 74);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // grdPacotes
            // 
            grdPacotes.BackgroundColor = Color.DimGray;
            grdPacotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPacotes.Columns.AddRange(new DataGridViewColumn[] { ID, Nome });
            grdPacotes.GridColor = Color.Black;
            grdPacotes.Location = new Point(41, 189);
            grdPacotes.Margin = new Padding(3, 2, 3, 2);
            grdPacotes.Name = "grdPacotes";
            grdPacotes.RowHeadersWidth = 51;
            grdPacotes.ScrollBars = ScrollBars.Vertical;
            grdPacotes.Size = new Size(539, 127);
            grdPacotes.TabIndex = 5;
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
            Nome.Width = 200;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(171, 163);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 22);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(259, 163);
            btnNovo.Margin = new Padding(3, 2, 3, 2);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(82, 22);
            btnNovo.TabIndex = 4;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // PacoteForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(613, 327);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(grdPacotes);
            Controls.Add(checkedListBox1);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PacoteForms";
            Text = "Cadastro de Pacotes";
            ((System.ComponentModel.ISupportInitialize)grdPacotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtID;
        private Label label2;
        private Label label1;
        private Label label3;
        private CheckedListBox checkedListBox1;
        private DataGridView grdPacotes;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private Button btnSalvar;
        private Button btnNovo;
    }
}