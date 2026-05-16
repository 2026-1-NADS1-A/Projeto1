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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLoginEscola
            // 
            btnLoginEscola.BackColor = Color.FromArgb(64, 64, 64);
            btnLoginEscola.FlatStyle = FlatStyle.Popup;
            btnLoginEscola.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginEscola.ForeColor = Color.White;
            btnLoginEscola.Location = new Point(230, 230);
            btnLoginEscola.Name = "btnLoginEscola";
            btnLoginEscola.Size = new Size(159, 37);
            btnLoginEscola.TabIndex = 3;
            btnLoginEscola.Text = "Login";
            btnLoginEscola.UseVisualStyleBackColor = false;
            // 
            // txtCnpjEscola
            // 
            txtCnpjEscola.BorderStyle = BorderStyle.FixedSingle;
            txtCnpjEscola.Location = new Point(230, 126);
            txtCnpjEscola.Name = "txtCnpjEscola";
            txtCnpjEscola.Size = new Size(159, 23);
            txtCnpjEscola.TabIndex = 4;
            // 
            // txtSenEscola
            // 
            txtSenEscola.BorderStyle = BorderStyle.FixedSingle;
            txtSenEscola.Location = new Point(230, 158);
            txtSenEscola.Name = "txtSenEscola";
            txtSenEscola.PasswordChar = '*';
            txtSenEscola.Size = new Size(159, 23);
            txtSenEscola.TabIndex = 5;
            // 
            // lblCnpjEscola
            // 
            lblCnpjEscola.AutoSize = true;
            lblCnpjEscola.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCnpjEscola.Location = new Point(133, 126);
            lblCnpjEscola.Name = "lblCnpjEscola";
            lblCnpjEscola.Size = new Size(72, 19);
            lblCnpjEscola.TabIndex = 6;
            lblCnpjEscola.Text = "Usuário";
            // 
            // lblSenEscola
            // 
            lblSenEscola.AutoSize = true;
            lblSenEscola.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenEscola.Location = new Point(145, 158);
            lblSenEscola.Name = "lblSenEscola";
            lblSenEscola.Size = new Size(60, 19);
            lblSenEscola.TabIndex = 7;
            lblSenEscola.Text = "Senha";
            lblSenEscola.Click += lblSenEscola_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo_Messier_removebg_preview;
            pictureBox1.Location = new Point(109, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // LoginEscola
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(613, 327);
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
    }
}