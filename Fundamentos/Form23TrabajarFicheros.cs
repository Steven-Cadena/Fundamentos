using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProyectoClases.Helpers;

namespace Fundamentos
{
    public partial class Form23TrabajarFicheros : Form
    {
        HelperFileNombres helper;
        public Form23TrabajarFicheros()
        {
            InitializeComponent();
            this.helper = new HelperFileNombres();
        }
        //hay que poner en el metodo async para poder usar el await 
        private async void btnLeerFichero_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                String path = ofd.FileName;
                List<String> nombres = await helper.ReadFileNombresAsync(path);
                this.lstNombres.Items.Clear();
                foreach (String nombre in nombres) 
                {
                    this.lstNombres.Items.Add(nombre);
                }
            }

        }

        private async void btnGuardarFichero_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) 
            {
                String path = save.FileName;
                String contenido = this.GetStringNombres();
                await helper.WriteFileNombresAsync(path, contenido);
                MessageBox.Show("Archivo Guardado");
            }
        }
        //METODO PARA RECUPERAR LOS NOMBRES 
        //DE LA LISTA Y SEPARARLOS CON ,
        public string GetStringNombres() 
        {
            String datos = "";
            foreach (String nombre in this.lstNombres.Items) 
            {
                datos += nombre + ",";
            }
            datos = datos.Trim(',');
            return datos;
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            String nombre = this.txtNombre.Text;
            this.lstNombres.Items.Add(nombre);
            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }
    }
}
