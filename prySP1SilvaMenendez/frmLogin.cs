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
        int intentos = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if ((txtNombre.Text == "Administrador" &&
                txtContraseña.Text == "adm135$") ||
                (txtNombre.Text == "Operador" &&
                txtContraseña.Text == "ope246$"))

            {
                frmInicio nuevoInicio = new frmInicio();
                nuevoInicio.Show();
                
                
            }
            else
            {
                MessageBox.Show("Datos Incorrectos. Acceso Denegado.");
                intentos++;
                if (intentos == 3)
                {
                    this.Close();
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

    }
}
