using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfValues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbColor.Items.Add("Amarillo");
            cbColor.SelectedValue = "hola";
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.Text = cbColor.SelectedIndex.ToString();
            //this.Text = cbColor.SelectedValue.ToString();
            this.Text = cbColor.Text;
        }
    }
}
