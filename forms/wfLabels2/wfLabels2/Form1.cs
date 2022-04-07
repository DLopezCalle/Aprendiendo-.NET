using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfLabels2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblRojo_Click_1(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Red;
            Text = "Color rojo seleccionado";
        }

        private void lblVerde_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Green;
        }

        private void lblAmarillo_Click_1(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Yellow;
        }

        private void lblResetear_Click(object sender, EventArgs e)
        {
            BackColor= System.Drawing.Color.White;
        }

        private void lblRojo_MouseHover(object sender, EventArgs e)
        {
            lblRojo.Cursor = Cursors.Hand;
        }

        private void lblVerde_MouseHover(object sender, EventArgs e)
        {
            lblVerde.Cursor = Cursors.Hand;
        }

        private void lblAmarillo_MouseHover(object sender, EventArgs e)
        {
            lblAmarillo.Cursor = Cursors.Hand;
        }

        private void lblResetear_MouseHover(object sender, EventArgs e)
        {
            lblResetear.Cursor = Cursors.Hand;
        }
    }
}
