namespace PrototipoMessier
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            btnPacotes = new Button();
            btnJogos = new Button();
            lblCadastros = new Label();
            btnEscolas = new Button();
            btnRelatorios = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.messier;
            pictureBox1.Location = new Point(163, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnPacotes
            // 
            btnPacotes.BackColor = Color.FromArgb(29, 114, 169);
            btnPacotes.Cursor = Cursors.Hand;
            btnPacotes.FlatStyle = FlatStyle.Flat;
            btnPacotes.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPacotes.ForeColor = Color.White;
            btnPacotes.Location = new Point(103, 160);
            btnPacotes.Name = "btnPacotes";
            btnPacotes.Size = new Size(142, 128);
            btnPacotes.TabIndex = 2;
            btnPacotes.Text = "Pacotes";
            btnPacotes.UseVisualStyleBackColor = false;
            btnPacotes.Click += btnPacotes_Click;
            // 
            // btnJogos
            // 
            btnJogos.BackColor = Color.FromArgb(29, 114, 169);
            btnJogos.Cursor = Cursors.Hand;
            btnJogos.FlatStyle = FlatStyle.Flat;
            btnJogos.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJogos.ForeColor = Color.White;
            btnJogos.Location = new Point(282, 160);
            btnJogos.Name = "btnJogos";
            btnJogos.Size = new Size(142, 128);
            btnJogos.TabIndex = 3;
            btnJogos.Text = "Jogos";
            btnJogos.UseVisualStyleBackColor = false;
            btnJogos.Click += btnJogos_Click;
            // 
            // lblCadastros
            // 
            lblCadastros.AutoSize = true;
            lblCadastros.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCadastros.ForeColor = Color.White;
            lblCadastros.Location = new Point(298, 88);
            lblCadastros.Name = "lblCadastros";
            lblCadastros.Size = new Size(113, 24);
            lblCadastros.TabIndex = 5;
            lblCadastros.Text = "Cadastros";
            // 
            // btnEscolas
            // 
            btnEscolas.BackColor = Color.FromArgb(29, 114, 169);
            btnEscolas.Cursor = Cursors.Hand;
            btnEscolas.FlatStyle = FlatStyle.Flat;
            btnEscolas.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEscolas.ForeColor = Color.White;
            btnEscolas.Location = new Point(457, 160);
            btnEscolas.Name = "btnEscolas";
            btnEscolas.Size = new Size(142, 128);
            btnEscolas.TabIndex = 6;
            btnEscolas.Text = "Escolas";
            btnEscolas.UseVisualStyleBackColor = false;
            btnEscolas.Click += btnEscolas_Click;
            // 
            // btnRelatorios
            // 
            btnRelatorios.BackColor = Color.FromArgb(29, 114, 169);
            btnRelatorios.FlatStyle = FlatStyle.Flat;
            btnRelatorios.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelatorios.ForeColor = Color.White;
            btnRelatorios.Location = new Point(163, 373);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(379, 45);
            btnRelatorios.TabIndex = 7;
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.UseVisualStyleBackColor = false;
            btnRelatorios.Click += btnRelatorios_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(704, 441);
            Controls.Add(btnRelatorios);
            Controls.Add(btnEscolas);
            Controls.Add(lblCadastros);
            Controls.Add(btnJogos);
            Controls.Add(btnPacotes);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Prototipo Messier";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnPacotes;
        private Button btnJogos;
        private Label lblCadastros;
        private Button btnEscolas;
        private Button btnRelatorios;
    }
}
