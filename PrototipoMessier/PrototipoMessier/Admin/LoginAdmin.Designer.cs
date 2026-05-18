namespace PrototipoMessier
{
    partial class LoginAdmin
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
            lblUsuAdmin = new Label();
            lblSenAdmin = new Label();
            txtUsuAdmin = new TextBox();
            txtSenAdmin = new TextBox();
            btnLoginAdmin = new Button();
            pictureBox1 = new PictureBox();
            lblAdmin = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsuAdmin
            // 
            lblUsuAdmin.AutoSize = true;
            lblUsuAdmin.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuAdmin.ForeColor = Color.White;
            lblUsuAdmin.Location = new Point(133, 153);
            lblUsuAdmin.Name = "lblUsuAdmin";
            lblUsuAdmin.Size = new Size(72, 19);
            lblUsuAdmin.TabIndex = 0;
            lblUsuAdmin.Text = "Usuário";
            // 
            // lblSenAdmin
            // 
            lblSenAdmin.AutoSize = true;
            lblSenAdmin.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenAdmin.ForeColor = Color.White;
            lblSenAdmin.Location = new Point(145, 188);
            lblSenAdmin.Name = "lblSenAdmin";
            lblSenAdmin.Size = new Size(60, 19);
            lblSenAdmin.TabIndex = 1;
            lblSenAdmin.Text = "Senha";
            // 
            // txtUsuAdmin
            // 
            txtUsuAdmin.BackColor = Color.White;
            txtUsuAdmin.BorderStyle = BorderStyle.FixedSingle;
            txtUsuAdmin.Location = new Point(230, 154);
            txtUsuAdmin.Name = "txtUsuAdmin";
            txtUsuAdmin.Size = new Size(159, 23);
            txtUsuAdmin.TabIndex = 0;
            // 
            // txtSenAdmin
            // 
            txtSenAdmin.BackColor = Color.White;
            txtSenAdmin.BorderStyle = BorderStyle.FixedSingle;
            txtSenAdmin.Location = new Point(230, 189);
            txtSenAdmin.Name = "txtSenAdmin";
            txtSenAdmin.PasswordChar = '*';
            txtSenAdmin.Size = new Size(159, 23);
            txtSenAdmin.TabIndex = 1;
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.BackColor = Color.FromArgb(29, 114, 169);
            btnLoginAdmin.FlatStyle = FlatStyle.Flat;
            btnLoginAdmin.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginAdmin.ForeColor = Color.White;
            btnLoginAdmin.Location = new Point(230, 249);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(159, 37);
            btnLoginAdmin.TabIndex = 2;
            btnLoginAdmin.Text = "Login";
            btnLoginAdmin.UseVisualStyleBackColor = false;
            btnLoginAdmin.Click += btnLoginAdmin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.messier;
            pictureBox1.Location = new Point(109, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmin.ForeColor = Color.White;
            lblAdmin.Location = new Point(278, 105);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(60, 19);
            lblAdmin.TabIndex = 5;
            lblAdmin.Text = "Admin";
            // 
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(613, 327);
            Controls.Add(lblAdmin);
            Controls.Add(pictureBox1);
            Controls.Add(btnLoginAdmin);
            Controls.Add(txtSenAdmin);
            Controls.Add(txtUsuAdmin);
            Controls.Add(lblSenAdmin);
            Controls.Add(lblUsuAdmin);
            Name = "LoginAdmin";
            Text = "Login Admin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuAdmin;
        private Label lblSenAdmin;
        private TextBox txtUsuAdmin;
        private TextBox txtSenAdmin;
        private Button btnLoginAdmin;
        private PictureBox pictureBox1;
        private Label lblAdmin;
    }
}