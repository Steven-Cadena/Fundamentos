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
    public partial class Form02SumarNumeros : Form
    {
        public Form02SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int num1, num2;
            //usamos el parse para convertir el valor de string a int
            num1 = int.Parse(this.txtNumero1.Text);
            num2 = int.Parse(this.txtNumero2.Text);
            int suma = num1 + num2;
            //usamos ToString para poder pintar el int 
            //1 solucion => this.lblResultado.Text = suma.ToString();
            this.lblResultado.Text = "La suma es: " + suma;
        }
    }
}
