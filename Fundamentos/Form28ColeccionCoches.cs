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
using ProyectoClases.Helpers;

namespace Fundamentos
{
    public partial class Form28ColeccionCoches : Form
    {
        XmlSerializer xmlSerial;
        //CochesCollection coches;
        HelperCoches helper;
        public Form28ColeccionCoches()
        {
            InitializeComponent();
            this.xmlSerial = new XmlSerializer(typeof(HelperCoches));
            this.helper = new HelperCoches();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String path = ofd.FileName; //cogemos el path 

                //this.helper.ReadFileMascotas(path);//funcion de la clase HelperMascotas para leer el fichero 
                //this.DibujarMascotas(); // llamamos al metodo de la clase para dibujar, cada vez que le demos a leer
            }
        }
        private void DibujarCoche() 
        {
            this.lstCoches.Items.Clear();
            foreach (Coche coche in this.helper.Coches) 
            {
                this.lstCoches.Items.Add(coche.Marca);
            }
        }

        private void btnNuevoCoche_Click(object sender, EventArgs e)
        {
            Coche coche = new Coche();
            coche.Marca = this.txtMarca.Text;
            coche.Modelo = this.txtModelo.Text;
            this.helper.Coches.Add(coche);
            this.DibujarCoche();
        }

        //private byte[]  ImageToByte(Image img)
        //{
        //    ImageConverter converter = new ImageConverter();
        //    this.helper.Coches.Ima
        //    return (byte[])converter.ConvertTo(img, typeof(byte[]));
        //}
    }
}
