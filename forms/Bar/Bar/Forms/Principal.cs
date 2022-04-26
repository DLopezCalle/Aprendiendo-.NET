using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bar.BBDD;

namespace Bar.Forms
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Datos.Categorias();
            cbCategorias.DataSource = Datos.lista_categorias;
            cbCategorias.ValueMember = "id";
            cbCategorias.DisplayMember = "nombre";            
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
