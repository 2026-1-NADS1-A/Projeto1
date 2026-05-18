namespace PrototipoMessier
{
    partial class SelecaoLoginForms
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
            btnLoginAdmin = new Button();
            btnLoginEscola = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.BackColor = Color.FromArgb(29, 114, 169);
            btnLoginAdmin.FlatStyle = FlatStyle.Flat;
            btnLoginAdmin.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginAdmin.ForeColor = Color.White;
            btnLoginAdmin.Location = new Point(163, 228);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(144, 129);
            btnLoginAdmin.TabIndex = 0;
            btnLoginAdmin.Text = "Admin";
            btnLoginAdmin.UseVisualStyleBackColor = false;
            btnLoginAdmin.Click += btnLoginAdmin_Click;
            // 
            // btnLoginEscola
            // 
            btnLoginEscola.BackColor = Color.FromArgb(29, 114, 169);
            btnLoginEscola.FlatStyle = FlatStyle.Flat;
            btnLoginEscola.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginEscola.ForeColor = Color.White;
            btnLoginEscola.Location = new Point(398, 228);
            btnLoginEscola.Name = "btnLoginEscola";
            btnLoginEscola.Size = new Size(144, 129);
            btnLoginEscola.TabIndex = 1;
            btnLoginEscola.Text = "Escola";
            btnLoginEscola.UseVisualStyleBackColor = false;
            btnLoginEscola.Click += btnLoginEscola_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(270, 151);
            label1.Name = "label1";
            label1.Size = new Size(181, 24);
            label1.TabIndex = 2;
            label1.Text = "Seu login é de: ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(18, 18, 18);
            pictureBox1.Image = Properties.Resources.messier;
            pictureBox1.Location = new Point(163, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // SelecaoLoginForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(704, 441);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnLoginEscola);
            Controls.Add(btnLoginAdmin);
            Name = "SelecaoLoginForms";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoginAdmin;
        private Button btnLoginEscola;
        private Label label1;
        private PictureBox pictureBox1;
    }
}