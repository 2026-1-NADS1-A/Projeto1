namespace PrototipoMessier
{
    partial class LoginEscola
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
            btnLoginEscola = new Button();
            txtCnpjEscola = new TextBox();
            txtSenEscola = new TextBox();
            lblCnpjEscola = new Label();
            lblSenEscola = new Label();
            pictureBox1 = new PictureBox();
            lblEscola = new Label();
            txtIPEscola = new TextBox();
            lblIPEscola = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLoginEscola
            // 
            btnLoginEscola.BackColor = Color.FromArgb(29, 114, 169);
            btnLoginEscola.FlatStyle = FlatStyle.Flat;
            btnLoginEscola.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginEscola.ForeColor = Color.White;
            btnLoginEscola.Location = new Point(230, 249);
            btnLoginEscola.Name = "btnLoginEscola";
            btnLoginEscola.Size = new Size(159, 37);
            btnLoginEscola.TabIndex = 3;
            btnLoginEscola.Text = "Login";
            btnLoginEscola.UseVisualStyleBackColor = false;
            btnLoginEscola.Click += btnLoginEscola_Click;
            // 
            // txtCnpjEscola
            // 
            txtCnpjEscola.BorderStyle = BorderStyle.FixedSingle;
            txtCnpjEscola.Location = new Point(230, 122);
            txtCnpjEscola.Name = "txtCnpjEscola";
            txtCnpjEscola.Size = new Size(159, 23);
            txtCnpjEscola.TabIndex = 4;
            // 
            // txtSenEscola
            // 
            txtSenEscola.BorderStyle = BorderStyle.FixedSingle;
            txtSenEscola.Location = new Point(230, 160);
            txtSenEscola.Name = "txtSenEscola";
            txtSenEscola.PasswordChar = '*';
            txtSenEscola.Size = new Size(159, 23);
            txtSenEscola.TabIndex = 5;
            // 
            // lblCnpjEscola
            // 
            lblCnpjEscola.AutoSize = true;
            lblCnpjEscola.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCnpjEscola.ForeColor = Color.White;
            lblCnpjEscola.Location = new Point(145, 126);
            lblCnpjEscola.Name = "lblCnpjEscola";
            lblCnpjEscola.Size = new Size(51, 19);
            lblCnpjEscola.TabIndex = 6;
            lblCnpjEscola.Text = "CNPJ";
            // 
            // lblSenEscola
            // 
            lblSenEscola.AutoSize = true;
            lblSenEscola.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenEscola.ForeColor = Color.White;
            lblSenEscola.Location = new Point(136, 164);
            lblSenEscola.Name = "lblSenEscola";
            lblSenEscola.Size = new Size(60, 19);
            lblSenEscola.TabIndex = 7;
            lblSenEscola.Text = "Senha";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.messier;
            pictureBox1.Location = new Point(109, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblEscola
            // 
            lblEscola.AutoSize = true;
            lblEscola.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEscola.ForeColor = Color.White;
            lblEscola.Location = new Point(277, 83);
            lblEscola.Name = "lblEscola";
            lblEscola.Size = new Size(62, 19);
            lblEscola.TabIndex = 9;
            lblEscola.Text = "Escola";
            // 
            // txtIPEscola
            // 
            txtIPEscola.BorderStyle = BorderStyle.FixedSingle;
            txtIPEscola.Location = new Point(230, 199);
            txtIPEscola.Name = "txtIPEscola";
            txtIPEscola.PasswordChar = '*';
            txtIPEscola.Size = new Size(159, 23);
            txtIPEscola.TabIndex = 10;
            // 
            // lblIPEscola
            // 
            lblIPEscola.AutoSize = true;
            lblIPEscola.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIPEscola.ForeColor = Color.White;
            lblIPEscola.Location = new Point(79, 203);
            lblIPEscola.Name = "lblIPEscola";
            lblIPEscola.Size = new Size(117, 19);
            lblIPEscola.TabIndex = 11;
            lblIPEscola.Text = "IP de Origem";
            // 
            // LoginEscola
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(613, 327);
            Controls.Add(lblIPEscola);
            Controls.Add(txtIPEscola);
            Controls.Add(lblEscola);
            Controls.Add(pictureBox1);
            Controls.Add(lblSenEscola);
            Controls.Add(lblCnpjEscola);
            Controls.Add(txtSenEscola);
            Controls.Add(txtCnpjEscola);
            Controls.Add(btnLoginEscola);
            Name = "LoginEscola";
            Text = "LoginEscola";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoginEscola;
        private TextBox txtCnpjEscola;
        private TextBox txtSenEscola;
        private Label lblCnpjEscola;
        private Label lblSenEscola;
        private PictureBox pictureBox1;
        private Label lblEscola;
        private TextBox txtIPEscola;
        private Label lblIPEscola;
    }
}