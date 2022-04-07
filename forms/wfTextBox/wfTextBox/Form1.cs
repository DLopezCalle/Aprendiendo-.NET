using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbOperando1.Text.Equals(""))
                    throw new NoHayOperandoException("ERROR: Problemas con el primer operando");
                else if (tbOperando2.Text.Equals(""))
                    throw new NoHayOperandoException("ERROR: Problemas con el segundo operando");
                {
                    int resultado = int.Parse(tbOperando1.Text) + int.Parse(tbOperando2.Text);
                    lblResultado.Text = $"{resultado}";
                }                    
            }
            catch (NoHayOperandoException ex)
            {
                lblResultado.Text = ex.Message;
                lblResultado.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
                lblResultado.ForeColor = Color.Red;
            }
        }
    }
}
