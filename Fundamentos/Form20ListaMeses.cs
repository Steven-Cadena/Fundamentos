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
    public partial class Form20ListaMeses : Form
    {
        String[] meses;
        List<int> temperaturas;
        public Form20ListaMeses()
        {
            InitializeComponent();
            this.temperaturas = new List<int>();

        }

        private void btnGenerarMeses_Click(object sender, EventArgs e)
        {
            this.lstMeses.Items.Clear();//limpiar la lista
            this.temperaturas.Clear();//limpiar temperaturas
            DateTime fecha = DateTime.Parse("01/01/2021"); //cogemos la fecha de enero 
            //this.meses = new String[] {"ENERO","FEBRERO","MARZO","ABRIL","MAYO","JUNIO","JULIO","AGOSTO","SEPTIEMBRE","OCTUBRE","NOVIEMBRE","DICIEMBRE" };
            Random random = new Random();
            for (int i = 0; i < 12; i++)
            {
                int temp = random.Next(-15, 45);
                this.temperaturas.Add(temp);
                //seleccionamos solamente el mes 
                String nombreMes = fecha.ToString("MMMM");
                this.lstMeses.Items.Add(nombreMes.ToUpper() + ": " + temp);
                //agregamos un mes a la fecha para poder coger el siguiente mes 
                fecha = fecha.AddMonths(1); 

            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int maxima, media, minima , suma;
            minima = this.temperaturas[0];
            maxima = this.temperaturas[0];
            suma = 0;
            foreach (int temp in this.temperaturas) 
            {
                suma += temp;
                maxima = Math.Max(temp, maxima);
                minima = Math.Min(temp, minima);
            }
            media = suma / this.temperaturas.Count;
            this.txtTempMaxima.Text = maxima.ToString();
            this.txt.Text = minima.ToString();
            this.txt2.Text = media.ToString();
        }
    }
}
