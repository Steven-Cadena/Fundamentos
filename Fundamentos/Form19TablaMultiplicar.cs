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
    public partial class Form19TablaMultiplicar : Form
    {
        List<TextBox> cajas;
        public Form19TablaMultiplicar()
        {
            InitializeComponent();
            this.cajas = new List<TextBox>();
            foreach (Control control in this.groupBox1.Controls) 
            {
                if (control is TextBox) 
                {
                    this.cajas.Add((TextBox)control);
                }
            }
        }

        private void btnMostrarTabla_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            int operacion = 1;
            this.cajas.Reverse();
            foreach (TextBox caj in this.cajas) 
            {
                caj.Text = (numero * operacion).ToString();
                operacion += 1;
            }
        }
    }
}
