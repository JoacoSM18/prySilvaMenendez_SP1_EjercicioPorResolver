using prySilvaMenendezSP1;

namespace prySP1SilvaMenendez
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int intentos = 0;
            string usuario = txtNombre.Text;
            string contraseña = txtContraseña.Text;
            string moduloSeleccionado = cmbModulo.Text;
            string[] modulosPermitidos = null;

            if ((usuario == "Adm" && contraseña == "@1a") ||
                (usuario == "John" && contraseña == "*2b") ||
                (usuario == "Ceci" && contraseña == "*@3c") ||
                (usuario == "God" && contraseña == "*@#4d"))
            {
                {
                    if (usuario == "Adm")
                    {
                        modulosPermitidos = new string[] { "ADM", "COM", "VTA" };
                    }
                    else if (usuario == "John")
                    {
                        modulosPermitidos = new string[] { "SIST" };
                    }
                    else if (usuario == "Ceci")
                    {
                        modulosPermitidos = new string[] { "ADM", "VTA" };
                    }
                    else if (usuario == "God")
                    {
                        modulosPermitidos = new string[] { "ADM", "COM", "VTA", "SIST" };
                    }
                    if (modulosPermitidos != null && modulosPermitidos.Contains(moduloSeleccionado))
                    {
                       
                        MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                        intentos++;
                        if (intentos == 3)
                        {
                            this.Close();
                        }
                    }
                }
            }
        }




        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
