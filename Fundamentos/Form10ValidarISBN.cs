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
    public partial class Form10ValidarISBN : Form
    {
        public Form10ValidarISBN()
        {
            InitializeComponent();
            int[] numeros = new int[4] { 14, 999, 52, 45 };
            int suma = 0;
            foreach (int num in numeros) 
            {
                suma += num;
            }
            this.lblResultado.Text = suma.ToString();//para cmabiar de int a string
            foreach (Form f in this.OwnedForms) 
            {
                f.Text = "Que esres ???";
            }
            foreach (Control c in this.Controls) {
                c.BackColor = Color.Yellow;
            }
        }

        private void btnComprobarISBN_Click(object sender, EventArgs e)
        {
            String numeros = this.txtNumero.Text;
            int longitud = numeros.Length;
            if (longitud < 10 || longitud > 10)
            {
                this.lblResultado.Text = "Debes introducir 10 números.";
            }
            else 
            {
                int operacion = 0;
                int sumaTotal = 0;
                for (int i = 0; i < longitud; i++)
                {
                    char numero = numeros[i];
                    int num = int.Parse(numero.ToString());//importante
                    operacion = num * i;
                    sumaTotal += operacion;
                }
                if (sumaTotal % 11 == 0)
                {
                    this.lblResultado.Text = "El ISB es correcto";
                }
                else
                {
                    this.lblResultado.Text = "El ISBN no es correcto";
                }
            }
        }
    }
}
