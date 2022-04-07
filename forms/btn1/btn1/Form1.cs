using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
            Text = "Color rojo seleccionado";
            btnResetear.Enabled = true;
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
            Text = "Color verde seleccionado";
            btnResetear.Enabled = true;
        }

        private void btnAmarillo_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
            Text = "Color amarillo seleccionado";
            btnResetear.Enabled = true;
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {

            BackColor = DefaultBackColor;
            Text = Name;
            btnResetear.Enabled = false;
        }
    }
}
