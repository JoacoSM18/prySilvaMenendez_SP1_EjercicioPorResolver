namespace prySilvaMenendezSP1
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            lblBienvenida = new Label();
            btnComenzar = new Button();
            lblSintepart = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 15F);
            lblBienvenida.ForeColor = SystemColors.ButtonHighlight;
            lblBienvenida.Location = new Point(135, -2);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(228, 28);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "INGRESE AL SISTEMA DE";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            lblBienvenida.Click += lblBienvenida_Click;
            // 
            // btnComenzar
            // 
            btnComenzar.Font = new Font("Segoe UI", 11F);
            btnComenzar.Location = new Point(345, 255);
            btnComenzar.Name = "btnComenzar";
            btnComenzar.Size = new Size(110, 28);
            btnComenzar.TabIndex = 1;
            btnComenzar.Text = "&COMENZAR";
            btnComenzar.UseVisualStyleBackColor = true;
            btnComenzar.Click += btnComenzar_click;
            // 
            // lblSintepart
            // 
            lblSintepart.AutoSize = true;
            lblSintepart.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSintepart.ForeColor = SystemColors.ButtonHighlight;
            lblSintepart.Location = new Point(125, 35);
            lblSintepart.Name = "lblSintepart";
            lblSintepart.Size = new Size(238, 45);
            lblSintepart.TabIndex = 2;
            lblSintepart.Text = "Sintepart S.R.L";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(106, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 130);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(479, 306);
            Controls.Add(pictureBox1);
            Controls.Add(lblSintepart);
            Controls.Add(btnComenzar);
            Controls.Add(lblBienvenida);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INICIO";
            Load += frmInicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Button btnComenzar;
        private Label lblSintepart;
        private PictureBox pictureBox1;
    }
}