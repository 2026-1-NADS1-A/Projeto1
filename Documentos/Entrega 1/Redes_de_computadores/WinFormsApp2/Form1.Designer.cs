namespace WinFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btvalidar = new Button();
            btIP = new Button();
            btlog = new Button();
            labelIP = new Label();
            txtIP = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btvalidar
            // 
            btvalidar.BackColor = SystemColors.InfoText;
            btvalidar.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btvalidar.ForeColor = SystemColors.Window;
            btvalidar.Location = new Point(466, 96);
            btvalidar.Name = "btvalidar";
            btvalidar.Size = new Size(94, 29);
            btvalidar.TabIndex = 0;
            btvalidar.Text = "Validar";
            btvalidar.UseVisualStyleBackColor = false;
            btvalidar.Click += btvalidar_Click;
            // 
            // btIP
            // 
            btIP.BackColor = SystemColors.InfoText;
            btIP.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btIP.ForeColor = SystemColors.Window;
            btIP.Location = new Point(159, 140);
            btIP.Name = "btIP";
            btIP.Size = new Size(94, 29);
            btIP.TabIndex = 1;
            btIP.Text = "Meu IP";
            btIP.UseVisualStyleBackColor = false;
            btIP.Click += btIP_Click;
            // 
            // btlog
            // 
            btlog.BackColor = SystemColors.MenuText;
            btlog.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btlog.ForeColor = SystemColors.Window;
            btlog.Location = new Point(366, 140);
            btlog.Name = "btlog";
            btlog.Size = new Size(94, 29);
            btlog.TabIndex = 2;
            btlog.Text = "Log";
            btlog.UseVisualStyleBackColor = false;
            btlog.Click += btlog_Click;
            // 
            // labelIP
            // 
            labelIP.AutoSize = true;
            labelIP.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIP.Location = new Point(123, 100);
            labelIP.Name = "labelIP";
            labelIP.Size = new Size(30, 20);
            labelIP.TabIndex = 3;
            labelIP.Text = "IP:";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(159, 96);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(301, 27);
            txtIP.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-10, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 81);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AcceptButton = btvalidar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(682, 220);
            Controls.Add(pictureBox1);
            Controls.Add(txtIP);
            Controls.Add(labelIP);
            Controls.Add(btlog);
            Controls.Add(btIP);
            Controls.Add(btvalidar);
            Name = "Form1";
            Text = "Validação de IP";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btvalidar;
        private Button btIP;
        private Button btlog;
        private Label labelIP;
        private TextBox txtIP;
        private PictureBox pictureBox1;
    }
}
