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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSistema));
            lblBienvenido = new Label();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblBienvenido.ForeColor = SystemColors.Control;
            lblBienvenido.Location = new Point(27, 70);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(352, 45);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSistema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISTEMA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
    }
}