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
    public partial class Form13ColeccionNumeros : Form
    {
        public Form13ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string elem = this.lstElementos.Text;
            //para eliminar los items una vez le demos al click
            this.lstElementos.Items.Clear();
            for (int i = 0; i <= 10; i++) 
            {
                Random random = new Random();
                int valor = random.Next(1, 10);
                this.lstElementos.Items.Add(valor);//agregar los numAleat a la lista
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int sumaTotal= 0;
            int pares = 0;
            int impares = 0;
            // esto es más completo
            //foreach (object obj in this.lstElementos.Items) 
            //{
            //    int num = (int)obj;
            //}
            foreach (int ind in this.lstElementos.SelectedItems)
            {
                sumaTotal += ind;
                if (ind % 2 == 0)
                {
                    pares += ind;
                }
                else 
                {
                    impares += ind;
                }
            }
            //convertimos un int a string para pintar en el txt
            this.txtSuma.Text = sumaTotal.ToString();
            this.txtPares.Text = pares.ToString();
            this.txtImpares.Text = impares.ToString();
        }
    }
}
