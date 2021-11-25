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

    public partial class Form18SumarNumeros : Form
    {

        int sumaTotal;
        List<Button> botones;
        public Form18SumarNumeros()
        {
            InitializeComponent();
            this.sumaTotal = 0;
            this.botones = new List<Button>();
            foreach (Control btn in this.panel1.Controls) 
            {
                if (btn is Button) 
                {
                    int numAleatorio = this.GetNumeroAleatorio();
                    btn.Text = numAleatorio.ToString();
                    btn.Click += SumarNumeros;
                }
            }
        }

        private void SumarNumeros(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            int valor = int.Parse(boton.Text);
            boton.BackColor = Color.Yellow;
            this.sumaTotal += valor;
            this.txtSumaNumeros.Text = this.sumaTotal.ToString();
        }

        int GetNumeroAleatorio() 
        {
            Random random = new Random();
            int valor = random.Next(1, 10);
            return valor;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            this.txtSumaNumeros.Text = "";
            this.sumaTotal = 0;
            foreach (Control btn in this.panel1.Controls) 
            {
                if (btn is Button) 
                { 
                    ((Button)btn).BackColor = Color.White;
                    int valorNuevo = this.GetNumeroAleatorio();
                    ((Button)btn).Text = valorNuevo.ToString();
                }
            }

        }
    }
}
