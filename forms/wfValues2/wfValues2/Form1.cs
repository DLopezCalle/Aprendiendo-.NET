using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfValues2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 255; i++)
            {
                cbRojo.Items.Add($"{i}");
                cbVerde.Items.Add($"{i}");
                cbAzul.Items.Add($"{i}");
            }
            cbRojo.SelectedIndex = 0;
            cbVerde.SelectedIndex = 0;
            cbAzul.SelectedIndex = 0;

            cbRojo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(cbRojo.SelectedIndex, int.Parse(cbVerde.Text), int.Parse(cbAzul.Text));
        }
    }
}
