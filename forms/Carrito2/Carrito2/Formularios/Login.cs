using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carrito2.BBDD;

namespace Carrito2.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool existe = false;
            if (tbNombre.Text != "" && tbPass.Text != "")
                existe = Datos.Logear(tbNombre.Text, tbPass.Text);
            if (existe == true)
            {
                Principal principal = new Principal();
                this.Hide();
                principal.ShowDialog();
                this.Show();
            }
            else
            {
                lblError.Text = "ERROR: Usuario o contraseña incorrectas";
                tbNombre.Text = "";
                tbPass.Text = "";
            }
        }
    }
}
