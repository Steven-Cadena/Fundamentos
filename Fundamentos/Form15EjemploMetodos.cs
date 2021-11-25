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
    public partial class Form15EjemploMetodos : Form
    {
        public Form15EjemploMetodos()
        {
            InitializeComponent();

            String texto = "Black Jueves";
            //texto es string y tiene sus metodos
            texto.ToUpper();
            //ALMACENAMOS TEXTO EN OBJECCT 
            Object obj = texto;
            //EN obj TENEMOS UN STRING PERO EN LA FORMA EN
            //LA QUE VIENE, NO LO RECONOCE
            

        }

        void DobleNumero(int numero) 
        {
            //MODIFICAMOS LA VARIABLE DEL METODO
            numero = numero * 2;
        }

        //al recibir clases podremos modificar el objeto enviado 
        //apuntan al mismo espacio de la memoria.
        void CambiarColorBoton(Button boton) 
        {
            boton.BackColor = Color.Red;
        }

        //PODEMOS HACER QUE UNA VARIBALE WRAPPER SEA REFENRECIADA 
        //MEDIANTE LA PALABRA ref
        void DobleNumeroReferencia(ref int numero) 
        {
            numero = numero * 2;
        }

        int GetDoble(int numero) 
        {
            return numero * 2;
        }


        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            int doble = this.GetDoble(num);
            //this.DobleNumero(num);
            this.lblResultado.Text = "Doble: " + doble;
        }

        private void btnMetodoClaseReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColorBoton(this.btnDobleReferencia);
            this.CambiarColorBoton(this.btnMetodoClaseReferencia);
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            //EN LA LLAMADA, TAMBIEN DEBEMOS PONER ref
            this.DobleNumeroReferencia(ref num);
            this.lblResultado.Text = "Doble: " + num;
        }

        private void btnMetodoClaseReferencia_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void lblMouse_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblMouse.Text = "X: " + e.X + ", Y: " + e.Y;
            
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esto evita que puedas pintar 
            //e.Handled = true;

            //DEBEMOS CONVERTIR LA TECLA DE BORRAR EN UN CHAR 
            //char barra = '/';
            //char teclaborrar = (char)8;//para windows
            char teclaBack = (char)Keys.Back;
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBack) 
            {
                e.Handled = true;
            }
        }

        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBack = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBack)
            {
                e.Handled = true;
            }
        }
    }
}
