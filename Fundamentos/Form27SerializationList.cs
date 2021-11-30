using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;//importante
using System.IO;//importante
using ProyectoClases;//importante

namespace Fundamentos
{
    public partial class Form27SerializationList : Form
    {
        XmlSerializer xmlSerial;
        MascotasCollection mascotas;
        public Form27SerializationList()
        {
            InitializeComponent();
            this.xmlSerial = new XmlSerializer(typeof(MascotasCollection));// creamos el xmlserial de tipo mascotas collection
            this.mascotas = new MascotasCollection();//instanciamos el objeto 
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtAnyos.Text);
            this.mascotas.Add(mascota);//añadimos cada mascota a la coleccion 
            this.PintarMascota(); // cada vez que añadimos una mascota la pintamos 
        }
        private void PintarMascota() 
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.mascotas) //recorremos la coleccion de mascotas 
            {
                this.lstMascotas.Items.Add(mascota.Nombre); // y dibujamos su nombre 
            }
        }

        private async void btnGuardarRegistros_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("listamascotas.xml");
            this.xmlSerial.Serialize(writer, this.mascotas);
            await writer.FlushAsync();
            writer.Close();
            this.lstMascotas.Items.Clear(); // limpiamos los items 
            this.mascotas.Clear();//limpiamos la coleccion
        }

        private void btnLeerRegistro_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("listamascotas.xml");

            //metemos los datos del fichero en nuestra coleccion de mascotas
            this.mascotas = (MascotasCollection)this.xmlSerial.Deserialize(reader);
            reader.Close();
            this.PintarMascota();

        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.lstMascotas.SelectedIndex;
            if (indice != -1) 
            {
                Mascota mascota = this.mascotas[indice];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtAnyos.Text = mascota.Years.ToString();
            }
        }
    }
}
