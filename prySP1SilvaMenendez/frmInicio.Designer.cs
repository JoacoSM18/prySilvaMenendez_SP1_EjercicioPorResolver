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
            lblBienvenida = new Label();
            btnComenzar = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BorderStyle = BorderStyle.Fixed3D;
            lblBienvenida.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblBienvenida.Location = new Point(26, 39);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(409, 47);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "BIENVENIDO AL SISTEMA";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            lblBienvenida.Click += lblBienvenida_Click;
            // 
            // btnComenzar
            // 
            btnComenzar.Font = new Font("Segoe UI", 11F);
            btnComenzar.Location = new Point(184, 124);
            btnComenzar.Name = "btnComenzar";
            btnComenzar.Size = new Size(110, 28);
            btnComenzar.TabIndex = 1;
            btnComenzar.Text = "&COMENZAR";
            btnComenzar.UseVisualStyleBackColor = true;
            btnComenzar.Click += btnComenzar_click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(479, 242);
            Controls.Add(btnComenzar);
            Controls.Add(lblBienvenida);
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INICIO";
            Load += frmInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Button btnComenzar;
    }
}