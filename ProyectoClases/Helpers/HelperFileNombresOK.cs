using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperFileNombresOK
    {
        //propiedades
        public string path;
        public List<String> Nombres { get; set; }
        //constructor
        public HelperFileNombresOK(string path) 
        {
            this.path = path;
            //PODRIAMOS RELLENAR DIRECTAMENTE LA COLECCION
            this.ReadFile();//llamamos al metodo para que nos lea el fichero
        }
        //privado por que no lo lee en el form, lo usamos solamente aquí 
        private void ReadFile() 
        {
            FileInfo file = new FileInfo(this.path);
            using (TextReader reader = file.OpenText()) 
            {
                String contenido = reader.ReadToEnd();
                string[] nombres = contenido.Split(',');//separamos lo que recibimos por comas 
                this.Nombres = new List<string>(nombres);//creamos los nombres y los añadimos
            }
        }
        public void WriteFile() 
        {
            String data = "";
            foreach (String name in this.Nombres) //recorremos los nombres
            {
                data += name + ","; //añadimos al string los nombres separados por una ,
            }
            data = data.Trim(',');//quitamos la última ,
            FileInfo file = new FileInfo(this.path);
            using (TextWriter writer = file.CreateText()) 
            {
                writer.Write(data);
                writer.Flush();
                writer.Close();
            }
        }
    }
}
