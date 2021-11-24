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
    public partial class Form07ValidarMail : Form
    {
        public Form07ValidarMail()
        {
            InitializeComponent();
        }

        private void btnValidarMail_Click(object sender, EventArgs e)
        {
            // mi solucion
            //string correo = this.txtMail.Text;
            //if (!correo.Contains("@"))
            //{
            //    this.lblResultado.Text = "Debe contener un @";
            //} 
            //if (correo.StartsWith("@") || correo.EndsWith("@"))
            //{
            //    this.lblResultado.Text = "No puede empezar o terminar por @";
            //} 

            ////para sacar el dominio del correo
            //int posicionPunto = correo.LastIndexOf(".");
            ////steven@gmail.com
            //string dominio = correo.Substring(posicionPunto+1);
            //int longitudDominio = dominio.Length;
            //if (!correo.Contains("."))
            //{
            //    this.lblResultado.Text = "Debe contener un . ";
            //}
            //else if (longitudDominio > 4 || longitudDominio < 2)  
            //{
            //    this.lblResultado.Text = "El dominio debe ser de 2 a 4 caracteres";
            //}
            //solucion de Paco
            String email = this.txtMail.Text;
            if (email.Contains("@") == false)
            {
                this.lblResultado.Text = "Debe contener un @";
            }
            else if (email.StartsWith("@") == true || email.EndsWith("@") == true)
            {
                this.lblResultado.Text = "No puede empezar o terminar por @";
            }
            else if (email.IndexOf("@") != email.LastIndexOf("@"))
            {
                this.lblResultado.Text = "Existe más de una @";
            }
            else if (email.IndexOf(".") == -1)
            {
                this.lblResultado.Text = "Debe existir un punto";
            }
            else if (email.LastIndexOf(".") < email.IndexOf("@"))
            {
                this.lblResultado.Text = "Debe existir un punto después de @";
            }
            else 
            {
                int ultimopunto = email.LastIndexOf(".") + 1;
                string dominio = email.Substring(ultimopunto);
                if (dominio.Length >= 2 && dominio.Length <= 4)
                {
                    this.lblResultado.Text = "Email correcto";
                }
                else 
                {
                    this.lblResultado.Text = "Email incorrecto.";
                }
            }
        }
    }
}
