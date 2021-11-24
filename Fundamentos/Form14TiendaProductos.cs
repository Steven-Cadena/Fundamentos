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
    public partial class Form14TiendaProductos : Form
    {
        public Form14TiendaProductos()
        {
            InitializeComponent();
        }

        private void btnInsertarProducto_Click(object sender, EventArgs e)
        {
            string texto = this.txtProducto.Text.ToUpper();
            if (this.lstTienda.Items.Contains(texto))
            {
                int posicion = this.lstTienda.Items.IndexOf(texto);
                //this.lstTienda..SelectedIndex = -1;
                this.lstTienda.SelectedIndex = posicion;
            }
            else 
            {
                this.lstTienda.Items.Add(texto);
            }
            this.txtProducto.SelectAll();
            this.txtProducto.Focus();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            //contar los items seleccionados
            int numerosSeleccionados = this.lstTienda.SelectedIndices.Count - 1;
            //bucle inverso para eliminar de atrás adelante
            for (int i = numerosSeleccionados; i >= 0; i--) 
            {
                //capturamos el indice a eliminar
                int ind = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(ind);
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            string texto = this.txtProducto.Text.ToUpper();
            for (int i = 0; i < this.lstTienda.SelectedItems.Count; i++) 
            {
                int ind = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items[ind] = texto;
            }
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            //hacemos un count para saber la cantidad uqe hay seleccionados
            int numerosSeleccion = this.lstTienda.SelectedIndices.Count - 1;

            for (int i = numerosSeleccion; i >= 0; i--) 
            {
                int indice = this.lstTienda.SelectedIndices[i];
                this.lstAlmacen.Items.Add(this.lstTienda.Items[indice]);
                this.lstTienda.Items.RemoveAt(indice);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            int productostotal = this.lstTienda.Items.Count -1;
            for (int i = 0; i < productostotal; i++) 
            {
                this.lstAlmacen.Items.Add(this.lstTienda.Items[i]);
            }
            this.lstTienda.Items.Clear();
            //solucion de paco
            //addrange acepta un objeto
            //this.lstAlmacen.Items.AddRange(this.lstTienda.Items);
            //this.lstTienda.Items.Clear();

        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int indice = this.lstAlmacen.SelectedIndex;
            string elem = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(indice);
            this.lstAlmacen.Items.Insert(indice - 1, elem);
            this.lstAlmacen.SelectedIndex = indice - 1;
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int indice = this.lstAlmacen.SelectedIndex;
            string elem = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(indice);
            this.lstAlmacen.Items.Insert(indice + 1, elem);
            this.lstAlmacen.SelectedIndex = indice + 1;
        }

        private void lstAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedIndex == 0)
            {
                this.btnSubir.Enabled = false;
            }
            else
            {
                this.btnSubir.Enabled = true;
            }

            if (this.lstAlmacen.SelectedIndex == this.lstAlmacen.Items.Count -1)
            {
                this.btnBajar.Enabled = false;
            }
            else
            {
                this.btnBajar.Enabled = true;
            }

        }
    }
}
