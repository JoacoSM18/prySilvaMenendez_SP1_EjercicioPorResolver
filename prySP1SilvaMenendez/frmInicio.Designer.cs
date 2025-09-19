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
            lblBienvenida.Location = new Point(37, 65);
            lblBienvenida.Margin = new Padding(4, 0, 4, 0);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(610, 67);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "BIENVENIDO AL SISTEMA";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            lblBienvenida.Click += lblBienvenida_Click;
            // 
            // btnComenzar
            // 
            btnComenzar.Font = new Font("Segoe UI", 11F);
            btnComenzar.Location = new Point(263, 207);
            btnComenzar.Margin = new Padding(4, 5, 4, 5);
            btnComenzar.Name = "btnComenzar";
            btnComenzar.Size = new Size(157, 47);
            btnComenzar.TabIndex = 1;
            btnComenzar.Text = "&COMENZAR";
            btnComenzar.UseVisualStyleBackColor = true;
            btnComenzar.Click += btnComenzar_click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 403);
            Controls.Add(btnComenzar);
            Controls.Add(lblBienvenida);
            Margin = new Padding(4, 5, 4, 5);
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