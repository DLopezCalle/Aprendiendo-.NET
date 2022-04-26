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
using Carrito2.Clases;

namespace Carrito2.Formularios
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Datos.Articulos();
            cbArticulos.DisplayMember = "descripcion";
            cbArticulos.ValueMember = "id";
            cbArticulos.DataSource = Datos.lista_articulos;

            this.Text = $"Hola, {Datos.usuario.Nombre.ToUpper()}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Articulo articulo = Datos.Articulo(Int32.Parse(cbArticulos.SelectedValue.ToString()));
            if (articulo != null)
            {
                label7.Text = "ENTRA";
                Datos.lista_carrito.Add(new Clases.Carrito(articulo, Int32.Parse(cbCantidad.Text)));
                int numArticulos = Int32.Parse($"{lblComprados.Text}");
                lblComprados.Text = $"{numArticulos + 1}";
            }
        }

        private void btnVerCarrito_Click(object sender, EventArgs e)
        {
            Carrito carrito = new Carrito();
            this.Hide();
            carrito.ShowDialog();
            this.Show();
        }
    }
}
