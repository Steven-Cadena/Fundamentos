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
    public partial class Form12SeleccionMultipleColeccion : Form
    {
        public Form12SeleccionMultipleColeccion()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtElemento.Text;
            this.lstElemento.Items.Add(elem);
            this.txtElemento.SelectAll();
            this.txtElemento.Focus();
        }

        private void btnSeleccionado_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            
            foreach(int ind in this.lstElemento.SelectedIndices)
            {
                indices += ind + ",";
            }
            foreach (object obj in this.lstElemento.SelectedItems) 
            {
                items += obj + ",";
            }
            this.lblPosicion.Text = indices;
            this.lblSeleccionado.Text = items;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

             //de donde eliminamos ??
             //NECESITAMOS UN BUCLE CONTADOR INVERSO PARA ELIMINAR LOS ITEMS
             //eliminamos de la coleccion de Items, los que están seleccionados
             int numeroseleccionados = this.lstElemento.SelectedIndices.Count -1;
             for (int i = numeroseleccionados; i >= 0; i--) 
             {
                 int ind = this.lstElemento.SelectedIndices[i];
                 this.lstElemento.Items.RemoveAt(ind);
             }
        }
    }
}
