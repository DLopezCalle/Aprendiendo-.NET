using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfComboBoxPueblos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            cbPueblo.Items.Add("Bilbao");
            cbPueblo.Items.Add("Etxebarri");
            cbPueblo.Items.Add("Santurtzi");
            */

            cbPueblo.DisplayMember = "Nombre";
            cbPueblo.ValueMember = "Cp";            

            List<Poblacion> list = new List<Poblacion>();

            list.Add(new Poblacion("48370", "Bermeo"));
            list.Add(new Poblacion("48200", "Durango"));
            list.Add(new Poblacion("48201", "Otxandio"));
            list.Add(new Poblacion("48901", "Barakaldo"));

            cbPueblo.DataSource = list;
            cbPueblo.SelectedIndex = 0;
        }

        private void cbPueblo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = cbPueblo.SelectedValue.ToString();
        }
    }
}
