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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //PARA ELIMINAR TENEMOS DOS METODOS 
            //.Remove(Object)
            //.RemoveAt(Index)
            //0 ANA, 1 LUCIA, 2 MARIA, 3 ANA
            //.Remove("ANA") => SOLO ELIMINA EL PRIMER ELEMENTO ANA
            //RemoveAt(4) => seleccionamos que ANA eliminar
            int indice = this.lstElemento.SelectedIndex;//seleccionamos el indice
            this.lstElemento.Items.RemoveAt(indice);//eliminamos ese indice
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            this.lstElemento.Items.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string elem = this.txtElemento.Text;
            int indice = this.lstElemento.SelectedIndex;
            this.lstElemento.Items[indice] = elem; //accedemos al item y lo modificamos
        }
    }
}
