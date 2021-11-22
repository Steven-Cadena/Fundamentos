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
            String[] diaSemana = new string[] { "Sábado","Domingo","Lunes","Martes","Miércoles","Jueves","Viernes"};
            decimal dia, mes, anyo,op1,op2,op3,op4,op5,op6,op7;
            dia = int.Parse(this.txtDia.Text);
            mes = int.Parse(this.txtMes.Text);
            anyo = int.Parse(this.txtAnyo.Text);

            if (mes == 1) {
                mes = 13;
                anyo = anyo - 1;
            } else if (mes == 2) {
                mes = 14;
                anyo = anyo - 1;
            }

            op1 = ((mes + 1) * 3) / 5;
            op2 = anyo / 4;
            op3 = anyo / 100;
            op4 = anyo / 400;

            op5 = Math.Truncate(dia + (mes * 2) + anyo + op1 + op2 - op3 + op4 + op2);
            op6 = op5 / 7;
            op7 = Math.Truncate(op5 - (op6 * 7));
            this.lblResultado.Text = diaSemana[op7];
        }
    }
}
