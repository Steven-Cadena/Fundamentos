using ProyectoClases.Helpers;
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
    public partial class Form24FilesNombres : Form
    {
        HelperFileNombresOK helper;
        public Form24FilesNombres()
        {
            InitializeComponent();
            //this.helper = new HelperFileNombresOK();
        }
        private void DibujarNombres() 
        {
            this.lstNombres.Items.Clear();
            //recorremos todos los nombres 
            foreach (String nombre in this.helper.Nombres) 
            {
                //añadimos esos nombres a la lista
                this.lstNombres.Items.Add(nombre);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            String name = this.txtNombre.Text;//cogemos el nuevo nombre a insertar
            this.helper.Nombres.Add(name);//lo insertamos en la lista de helper
            this.DibujarNombres();// llamamos a la función para que nos lo pinte 
        }

        private void btnLeerFichero_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                String path = ofd.FileName;
                this.helper = new HelperFileNombresOK(path); //creamos un nuevo helper y le pasamos una ruta
                this.DibujarNombres();
            }
        }

        private void btnGuardarFichero_Click(object sender, EventArgs e)
        {
                this.helper.WriteFile();
                MessageBox.Show("Datos guardados.");
        }
    }
}
