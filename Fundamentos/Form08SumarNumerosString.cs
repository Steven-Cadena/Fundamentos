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
    public partial class Form08SumarNumerosString : Form
    {
        public Form08SumarNumerosString()
        {
            InitializeComponent();
        }

        private void btnSumarNumeros_Click(object sender, EventArgs e)
        {
            bool isNumber = true;
            string textoNumeros = this.txtNumeros.Text;
            for (int i = 0; i < textoNumeros.Length; i++) 
            {
                if (char.IsDigit(textoNumeros[i]) == false) 
                {
                    isNumber = false;
                    break;
                }
            }
            if (isNumber == false)
            {
                MessageBox.Show("Debe escribir números en la caja", "Warning");
                this.txtNumeros.SelectAll();
                this.txtNumeros.Focus();
            }
            else 
            {
                int suma = 0;
                for (int i = 0; i< textoNumeros.Length; i++) 
                {
                    char caracter = textoNumeros[i];//capturamos el caracter
                    //LA CLASE CONVERT SIRVE PARA CONVERSIONES ESPECIALES 
                    //int numero = Convert.ToInt32(caracter);//convertimos cada caracter a numero
                    //primero debemos crearlo a cadena y de ahí a entero
                    int numero = int.Parse(caracter.ToString());
                    suma += numero;
                }
                this.lblResultado.Text = "La suma es " + suma;
            }
        }
    }
}
