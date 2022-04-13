using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prestamos.Clases;
using Prestamos.Datos;

namespace Prestamos.Formularios
{
    public partial class Prestar : Form
    {
        public Prestar()
        {
            InitializeComponent();
        }

        private void Prestar_Load(object sender, EventArgs e)
        {
            cbAmigos.DisplayMember = "nombre";
            cbAmigos.ValueMember = "id";
            cbAmigos.DataSource = Datos.Datos.Amigos();

            cbLibros.DisplayMember = "titulo";
            cbLibros.ValueMember = "id";
            cbLibros.DataSource = Datos.Datos.LibrosDisponibles();
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            int filas = 0;
            Amigo amigo = null;
            Libro libro = null;

            amigo = (Amigo)cbAmigos.SelectedItem;
            libro = (Libro)cbLibros.SelectedItem;

            if (amigo != null && libro != null)
                filas = Datos.Datos.HacerPrestamo(libro, amigo);

            if (filas == 1)
            {
                lbPrestado.Text = "El libro se prestó correctamente";

                cbAmigos.Text = "";
                cbLibros.Text = "";

                cbAmigos.DisplayMember = "nombre";
                cbAmigos.ValueMember = "id";
                cbAmigos.DataSource = Datos.Datos.Amigos();

                cbLibros.DisplayMember = "titulo";
                cbLibros.ValueMember = "id";
                cbLibros.DataSource = Datos.Datos.LibrosDisponibles();
            }                
            else
                lbPrestado.Text = "El libro NO se pudo prestar...";


        }
    }
}
