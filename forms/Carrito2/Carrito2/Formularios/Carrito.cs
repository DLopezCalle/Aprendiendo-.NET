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
    public partial class Carrito : Form
    {
        public Carrito()
        {
            InitializeComponent();
        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            dgvCarrito.DataSource = Datos.lista_carrito;
            //dgvCarrito.DisplayMember = "descripcion";
            //dgvCarrito.ValueMember = "id";
            
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Datos.NuevaFactura();
        }
    }
}
