using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization; //importante
using System.IO; //importante
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form26SerializationObject : Form
    {
        XmlSerializer xmlserial;
        public Form26SerializationObject()
        {
            InitializeComponent();
            this.xmlserial = new XmlSerializer(typeof(Mascota));
        }

        private async  void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtAnyos.Text);
            //PARA SERIALIZAR(ESCRIBIR) SE UTILIZA EL OBJETO DE System.IO
            //StreamWriter
            //NO IMPORTA LA EXTENSION DEL ARCHIVO AL GUARDARLO
            //SIEMPRE TENDRA FORMATO XML INTERNAMENTE
            StreamWriter writer = new StreamWriter("mascota.xml");//creamos el fichero
            //CON EL METODO SERILIZE ALMACENAMOS EL OBJETO 
            // Y XML SE ENCARGA DE DARLE FORMA String
            this.xmlserial.Serialize(writer, mascota);
            await writer.FlushAsync(); // siempre que creamos ficheros hay que usarlo
            writer.Close();
            this.txtNombre.Text = "";//limpiamos las cajas
            this.txtRaza.Text = "";
            this.txtAnyos.Text = "";
        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("mascota.xml");
            //LA DESERIALIZACION NOS DEVUELVE DIRECTAMENTE EL OBJETO 
            //MEDIANTE EL METODO Desearialize
            Mascota mascota = (Mascota)this.xmlserial.Deserialize(reader); // devuelve un object y lo convertimos a Mascota
            reader.Close();
            this.txtNombre.Text = mascota.Nombre;
            this.txtRaza.Text = mascota.Raza;
            this.txtAnyos.Text = mascota.Years.ToString();//convertimos a string para pintar en la caja de texto el numero de años

        }
    }
}
