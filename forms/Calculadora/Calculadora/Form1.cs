using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblResultado_TextChanged(object sender, EventArgs e)
        {
        }

        private void LeerNum (string num)
        {
            lblResultado.Text = num;
        }

        private void LeerOp (string op)
        {
            if (!lblResultado.Equals("0") && !lblResultado.Equals("C"))
            {
                if (Utilidad.operador.Equals("") || Utilidad.operador.Equals("=")) // El primer signo
                {
                    Utilidad.n1 = int.Parse(lblResultado.Text);
                    Utilidad.operador = op;
                }
                else // Segundo signo
                {
                    // Cuando tenga funcion para operar meterlo aqui y guardar el resultado y cambiar operador
                    Utilidad.n2 = int.Parse(lblResultado.Text);
                    EjecutarOperacion ();
                    Utilidad.operador = op;
                }
            }
            else
            {
                /*
                Utilidad.n2 = int.Parse(lblResultado.Text);
                EjecutarOperacion();
                Utilidad.operador = op;
                */
                Utilidad.Resetear();
                lblResultado.Text = "0";
            }
        }

        private void EjecutarOperacion()
        {
            int resultado = 0;
            switch (Utilidad.operador)
            {
                case "+":
                    resultado = Utilidad.Sumar();
                    break;
                case "-":
                    resultado = Utilidad.Restar();
                    break;
                case "x":
                    resultado = Utilidad.Multiplicar();
                    break;
                case "/":
                    resultado = Utilidad.Dividir();
                    break;
                case "%":
                    resultado = Utilidad.Resto();
                    break;
            }
            Utilidad.n1 = resultado;
            Utilidad.operador = "";
            lblResultado.Text = $"{Utilidad.n1}";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            LeerNum(btn.Text);
        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            LeerOp(btn.Text);
        }
    }
}
