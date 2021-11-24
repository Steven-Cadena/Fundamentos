using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form04DiaNacimiento : Form
    {
        public Form04DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnCalcularDia_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int anyo = int.Parse(this.txtAnyo.Text);
            if (mes == 1)
            {
                mes = 13;
                //anyo = anyo - 1;
                anyo -= 1;
            }
            else if (mes == 2)
            {
                mes = 14;
                anyo -= 1;
            }
            int op1, op2, op3, op4, op5, op6, resultado;
            op1 = ((mes + 1) * 3) / 5;
            op2 = anyo / 4;
            op3 = anyo / 100;
            op4 = anyo / 400;
            op5 = dia + (mes * 2) + anyo + op1 + op2 - op3 + op4 + 2;
            op6 = op5 / 7;
            resultado = op5 - (op6 * 7);
            string diasemana = "";
            if (resultado == 0)
            {
                diasemana = "SABADO";
            }
            else if (resultado == 1)
            {
                diasemana = "DOMINGO";
            }
            else if (resultado == 2)
            {
                diasemana = "LUNES";
            }
            else if (resultado == 3)
            {
                diasemana = "MARTES";
            }
            else if (resultado == 4)
            {
                diasemana = "MIERCOLES";
            }
            else if (resultado == 5)
            {
                diasemana = "JUEVES";
            }
            else if (resultado == 6)
            {
                diasemana = "VIERNES";
            }
            this.lblResultado.Text = diasemana;
        }

    }
}
