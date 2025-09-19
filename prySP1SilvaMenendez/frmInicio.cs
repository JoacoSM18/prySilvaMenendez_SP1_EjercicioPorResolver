using prySP1SilvaMenendez;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace prySilvaMenendezSP1
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
        
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void btnComenzar_click(object sender, EventArgs e)
        {
            frmLogin loginFormulario = new frmLogin();
            loginFormulario.Show();
            this.Hide();
        }
    }
}
