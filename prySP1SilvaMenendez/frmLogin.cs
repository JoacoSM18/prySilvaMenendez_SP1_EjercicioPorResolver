using prySilvaMenendez_SP1_EjercicioPorResolver;
using prySilvaMenendezSP1;

namespace prySP1SilvaMenendez
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int intentos = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtNombre.Text;
            string contraseña = txtContraseña.Text;
            string moduloSeleccionado = cmbModulo.Text;
            string[] modulosPermitidos = null;

            if (usuario == "" || contraseña == "" || cmbModulo.SelectedItem == null)
            {
                MessageBox.Show("Datos Incompletos, Complete Todos los Campos");
                return;
            }
            if ((usuario == "Adm" && contraseña == "@1a") ||
                (usuario == "John" && contraseña == "*2b") ||
                (usuario == "Ceci" && contraseña == "*@3c") ||
                (usuario == "God" && contraseña == "*@#4d"))
            {
                if (usuario == "Adm") modulosPermitidos = new string[] { "ADM", "COM", "VTA" };
                else if (usuario == "John") modulosPermitidos = new string[] { "SIST" };
                else if (usuario == "Ceci") modulosPermitidos = new string[] { "ADM", "VTA" };
                else if (usuario == "God") modulosPermitidos = new string[] { "ADM", "COM", "VTA", "SIST" };

                if (modulosPermitidos.Contains(moduloSeleccionado))
                {
                    this.Hide();
                    frmSistema f = new frmSistema();
                    f.Text = usuario;
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos. Acceso Denegado.");
                    intentos++;
                    if (intentos >= 3)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Datos Incorrectos. Acceso Denegado.");
                intentos++;
                if (intentos >= 3)
                {
                    this.Close();
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
