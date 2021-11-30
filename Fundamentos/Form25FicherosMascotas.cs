using ProyectoClases;
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
    public partial class Form25FicherosMascotas : Form
    {
        HelperMascotas helper;
        public Form25FicherosMascotas()
        {
            InitializeComponent();
            this.helper = new HelperMascotas();
        }


        private void DibujarMascotas() 
        {
            this.lstMascotas.Items.Clear(); // limpiamos la lista de mascotas del form 
            foreach (Mascota mascota in this.helper.Mascotas) //hacemos un foreach para coger cada mascota guardada
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();//creamos la nueva mascota 
            mascota.Nombre = this.txtNombre.Text;//añadimos el nombre de la caja 
            mascota.Raza = this.txtRaza.Text;//añadimos la raza de la caja 
            this.helper.Mascotas.Add(mascota);// añadimos a nuestra coleccion de mascota 
            this.DibujarMascotas();
        }

        private async void btnGuardarRegistros_Click(object sender, EventArgs e) //importante poner async (asincrono)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK) 
            {
                String path = sfd.FileName;
                await this.helper.SaveFileMascotasAsync(path);
            }
        }

        private void btnLeerRegistro_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                String path = ofd.FileName; //cogemos el path 
                this.helper.ReadFileMascotas(path);//funcion de la clase HelperMascotas para leer el fichero 
                this.DibujarMascotas(); // llamamos al metodo de la clase para dibujar, cada vez que le demos a leer
            }
        }

        //funcion para poner en las cajas el valor seleccionado de la lista 
        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstMascotas.SelectedIndex != -1) 
            {
                Mascota mascota = this.helper.Mascotas[this.lstMascotas.SelectedIndex];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
            }
        }
    }
}
