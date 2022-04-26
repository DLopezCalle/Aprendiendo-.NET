using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cbCategorias.ValueMember = "Id";
            cbCategorias.DisplayMember = "nombre";
            cbCategorias.DataSource = Datos.BBDD.Categorias();
            dgvProductos.Columns[1].Visible= false;
            dgvProductos.DataSource = Datos.BBDD.Productos((int)cbCategorias.SelectedValue);
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvProductos.DataSource = Datos.BBDD.Productos((int)cbCategorias.SelectedValue);

        }
    }
}
