namespace PrototipoMessier
{
    partial class RelEscolaForms
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
            btnImprimir = new Button();
            txtRelatorio = new TextBox();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(12, 31);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // txtRelatorio
            // 
            txtRelatorio.BackColor = Color.Black;
            txtRelatorio.ForeColor = Color.White;
            txtRelatorio.Location = new Point(12, 78);
            txtRelatorio.Multiline = true;
            txtRelatorio.Name = "txtRelatorio";
            txtRelatorio.ScrollBars = ScrollBars.Vertical;
            txtRelatorio.Size = new Size(589, 237);
            txtRelatorio.TabIndex = 1;
            txtRelatorio.TextChanged += txtRelatorio_TextChanged;
            // 
            // RelEscolaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(613, 327);
            Controls.Add(txtRelatorio);
            Controls.Add(btnImprimir);
            Name = "RelEscolaForms";
            Text = "RelEscolaForms";
            Load += RelEscolaForms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImprimir;
        private TextBox txtRelatorio;
    }
}