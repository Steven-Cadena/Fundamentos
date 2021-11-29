using ProyectoClases;
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
    public partial class Form22EjemploClases : Form
    {
        List<Meses> mesesGuardados;
        public Form22EjemploClases()
        {
            InitializeComponent();
            //inicializar siempre aqui los objetos 
            mesesGuardados = new List<Meses>();
        }

        private void btnGenerarMeses_Click(object sender, EventArgs e)
        {
            this.mesesGuardados.Clear();
            this.lstMeses.Items.Clear();
            DateTime fecha = DateTime.Parse("01/01/2021");
            Random random = new Random();
            for (int i = 0; i < 12; i++)
            {
                
                int tempMaxima = random.Next(11, 45);
                int tempMinima = random.Next(-15,10);
                //seleccionamos solamente el mes 
                String nombreMes = fecha.ToString("MMMM");
                Meses mes = new Meses(nombreMes,tempMaxima,tempMinima);
                mesesGuardados.Add(mes);
                this.lstMeses.Items.Add(mes.Nombre);
                //agregamos un mes a la fecha para poder coger el siguiente mes 
                fecha = fecha.AddMonths(1);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int indice = this.lstMeses.SelectedIndex;

            if (indice != -1) {
                Meses mes = this.mesesGuardados[indice];
                this.txtNombreMes.Text = mes.Nombre;
                this.txtTempMaxima.Text = mes.TemperaturaMaxima.ToString();
                this.txtTempMinima.Text = mes.TemperaturaMinima.ToString();
                this.txtTempMediaMensual.Text = (mes.GetMediaMensual()).ToString();
            }
        }
    }
}
