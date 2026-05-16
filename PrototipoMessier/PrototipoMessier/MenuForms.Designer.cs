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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo_Messier_removebg_preview;
            pictureBox1.Location = new Point(159, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnPacotes
            // 
            btnPacotes.BackColor = Color.FromArgb(64, 64, 64);
            btnPacotes.Cursor = Cursors.Hand;
            btnPacotes.FlatStyle = FlatStyle.Popup;
            btnPacotes.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPacotes.ForeColor = Color.White;
            btnPacotes.Location = new Point(159, 133);
            btnPacotes.Name = "btnPacotes";
            btnPacotes.Size = new Size(116, 109);
            btnPacotes.TabIndex = 2;
            btnPacotes.Text = "Pacotes";
            btnPacotes.UseVisualStyleBackColor = false;
            btnPacotes.Click += btnPacotes_Click;
            // 
            // btnJogos
            // 
            btnJogos.BackColor = Color.FromArgb(64, 64, 64);
            btnJogos.Cursor = Cursors.Hand;
            btnJogos.FlatStyle = FlatStyle.Popup;
            btnJogos.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJogos.ForeColor = Color.White;
            btnJogos.Location = new Point(299, 133);
            btnJogos.Name = "btnJogos";
            btnJogos.Size = new Size(110, 109);
            btnJogos.TabIndex = 3;
            btnJogos.Text = "Jogos";
            btnJogos.UseVisualStyleBackColor = false;
            btnJogos.Click += btnJogos_Click;
            // 
            // lblCadastros
            // 
            lblCadastros.AutoSize = true;
            lblCadastros.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCadastros.Location = new Point(312, 90);
            lblCadastros.Name = "lblCadastros";
            lblCadastros.Size = new Size(81, 16);
            lblCadastros.TabIndex = 5;
            lblCadastros.Text = "Cadastros";
            lblCadastros.Click += label1_Click;
            // 
            // btnEscolas
            // 
            btnEscolas.BackColor = Color.FromArgb(64, 64, 64);
            btnEscolas.Cursor = Cursors.Hand;
            btnEscolas.FlatStyle = FlatStyle.Popup;
            btnEscolas.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEscolas.ForeColor = Color.White;
            btnEscolas.Location = new Point(428, 133);
            btnEscolas.Name = "btnEscolas";
            btnEscolas.Size = new Size(110, 109);
            btnEscolas.TabIndex = 6;
            btnEscolas.Text = "Escolas";
            btnEscolas.UseVisualStyleBackColor = false;
            btnEscolas.Click += btnEscolas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(700, 338);
            Controls.Add(btnEscolas);
            Controls.Add(lblCadastros);
            Controls.Add(btnJogos);
            Controls.Add(btnPacotes);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Prototipo Messier";
            Load += Form1_Load;
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
    }
}
