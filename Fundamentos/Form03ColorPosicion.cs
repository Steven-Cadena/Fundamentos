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
    public partial class Form03ColorPosicion : Form
    {
        public Form03ColorPosicion()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            byte rojo, verde, azul;
            //cogemos el valor de las cajas 
            rojo = byte.Parse(this.txtRojo.Text);
            verde = byte.Parse(this.txtVerde.Text);
            azul = byte.Parse(this.txtAzul.Text);
            //cambiamos el color al fondo del formulario
            this.BackColor  = Color.FromArgb(rojo,verde,azul);
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int posX, posY;
            //cogemos los valores de la posicion
            posX = int.Parse(this.txtPosicionX.Text);
            posY = int.Parse(this.txtPosicionY.Text);
            //cambiamos la posicion del boton
            btnPosicion.Location = new Point(posX,posY);
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            if (numero > 0)
            {
                this.lblResultado.Text = "Positivo";
                this.lblResultado.ForeColor = Color.Green;
            }
            else if (numero == 0)
            {
                this.lblResultado.Text = "CERO";
                this.lblResultado.ForeColor = Color.Blue;
            }
            else 
            {
                this.lblResultado.Text = "Negativo";
                this.lblResultado.ForeColor = Color.Red;
            }
        }
    }
}
