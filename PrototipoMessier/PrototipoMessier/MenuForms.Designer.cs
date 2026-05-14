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
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            jogosToolStripMenuItem = new ToolStripMenuItem();
            pacotesToolStripMenuItem = new ToolStripMenuItem();
            escolasToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            escolasToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            btnPacotes = new Button();
            btnJogos = new Button();
            lblCadastros = new Label();
            btnEscolas = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo_Messier_removebg_preview;
            pictureBox1.Location = new Point(159, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.BackColor = Color.Transparent;
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jogosToolStripMenuItem, pacotesToolStripMenuItem, escolasToolStripMenuItem1 });
            cadastrosToolStripMenuItem.ForeColor = Color.Black;
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            cadastrosToolStripMenuItem.Click += cadastrosToolStripMenuItem_Click;
            // 
            // jogosToolStripMenuItem
            // 
            jogosToolStripMenuItem.BackColor = Color.Transparent;
            jogosToolStripMenuItem.Name = "jogosToolStripMenuItem";
            jogosToolStripMenuItem.Size = new Size(115, 22);
            jogosToolStripMenuItem.Text = "Jogos";
            jogosToolStripMenuItem.Click += jogosToolStripMenuItem_Click;
            // 
            // pacotesToolStripMenuItem
            // 
            pacotesToolStripMenuItem.BackColor = Color.Transparent;
            pacotesToolStripMenuItem.Name = "pacotesToolStripMenuItem";
            pacotesToolStripMenuItem.Size = new Size(115, 22);
            pacotesToolStripMenuItem.Text = "Pacotes";
            // 
            // escolasToolStripMenuItem1
            // 
            escolasToolStripMenuItem1.Name = "escolasToolStripMenuItem1";
            escolasToolStripMenuItem1.Size = new Size(115, 22);
            escolasToolStripMenuItem1.Text = "Escolas";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.Transparent;
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { escolasToolStripMenuItem });
            toolStripMenuItem1.ForeColor = Color.Black;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(71, 20);
            toolStripMenuItem1.Text = "Relatórios";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // escolasToolStripMenuItem
            // 
            escolasToolStripMenuItem.Name = "escolasToolStripMenuItem";
            escolasToolStripMenuItem.Size = new Size(112, 22);
            escolasToolStripMenuItem.Text = "Escolas";
            escolasToolStripMenuItem.Click += escolasToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.BackColor = Color.Transparent;
            sairToolStripMenuItem.ForeColor = Color.Black;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, toolStripMenuItem1, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // btnPacotes
            // 
            btnPacotes.BackColor = Color.FromArgb(64, 64, 64);
            btnPacotes.Cursor = Cursors.Hand;
            btnPacotes.FlatStyle = FlatStyle.Popup;
            btnPacotes.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPacotes.ForeColor = Color.White;
            btnPacotes.Location = new Point(159, 185);
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
            btnJogos.Location = new Point(300, 185);
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
            lblCadastros.Location = new Point(315, 146);
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
            btnEscolas.Location = new Point(428, 185);
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Prototipo Messier";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem jogosToolStripMenuItem;
        private ToolStripMenuItem pacotesToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem escolasToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem escolasToolStripMenuItem1;
        private Button btnPacotes;
        private Button btnJogos;
        private Label lblCadastros;
        private Button btnEscolas;
    }
}
