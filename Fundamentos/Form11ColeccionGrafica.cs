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
    public partial class Form11ColeccionGrafica : Form
    {
        public Form11ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtElemento.Text;
            this.lstElemento.Items.Add(elem);//añadimos el elemento 

        }

        private void lstElemento_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblPosicion.Text = "Indice: "+ 
                this.lstElemento.SelectedIndex.ToString();
            this.lblSeleccionado.Text = "Item: "
                + this.lstElemento.SelectedItem;
        }
    }
}
