namespace prySilvaMenendez_SP1_EjercicioPorResolver
{
    partial class frmSistema
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
            lblBienvenido = new Label();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblBienvenido.ForeColor = SystemColors.Control;
            lblBienvenido.Location = new Point(58, 37);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(299, 37);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenido al Sistema";
            // 
            // frmSistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(404, 267);
            Controls.Add(lblBienvenido);
            Name = "frmSistema";
            Text = "SISTEMA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
    }
}