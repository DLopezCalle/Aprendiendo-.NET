using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos.Formularios
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            Prestar prestar = new Prestar();
            this.Hide();
            prestar.ShowDialog();
            this.Show();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            Devolver devolver = new Devolver();
            this.Hide();
            devolver.ShowDialog();
            devolver.Show();
        }
    }
}
