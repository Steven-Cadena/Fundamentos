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
    public partial class Form05ClaseDateTime : Form
    {
        //Constructor de la clase para inicializar 
        public Form05ClaseDateTime()
        {
            InitializeComponent();//esto no se toca es para el diseño
            //con now cogemos la fecha actual 
            this.txtFechaActual.Text = DateTime.Now.ToString();
        }

        private void chkFormato_CheckedChanged(object sender, EventArgs e)
        {
            //recuperamos la fecha el txt
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            if (this.chkFormato.Checked == true)
            {
                this.txtFechaActual.Text = fecha.ToShortDateString();
            }
            else 
            {
                this.txtFechaActual.Text = fecha.ToLongDateString();
            }
        }

        private void btnIncremento_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            //importante para cambiar el objeto fecha hay que igualarlo
            //fecha = fecha.AddDays(incremento);
            if (this.rdbDia.Checked == true)
            {
                fecha = fecha.AddDays(incremento);
            }
            else if (this.rdbMes.Checked == true)
            {
                fecha = fecha.AddMonths(incremento);
            }
            else 
            {
                fecha = fecha.AddYears(incremento);
            }
            this.txtNuevaFecha.Text = fecha.ToString();
        }
    }
}
