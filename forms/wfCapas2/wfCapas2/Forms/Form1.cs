using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfCapas2.Datos;
using wfCapas2.Clases;

namespace wfCapas2.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BBDD.Provincias();
            BBDD.Poblaciones();

            cbProvincias.ValueMember = "Id";
            cbProvincias.DisplayMember = "Nombre";

            cbProvincias.DataSource = BBDD.lista_provincias;
        }

        private void cbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Provincia provincia = (Provincia)cbProvincias.SelectedItem;

            BBDD.Poblaciones(provincia);

            cbPoblaciones.ValueMember = "Id";
            cbPoblaciones.DisplayMember = "Nombre";

            cbPoblaciones.DataSource = BBDD.lista_poblaciones;

        }
    }
}
