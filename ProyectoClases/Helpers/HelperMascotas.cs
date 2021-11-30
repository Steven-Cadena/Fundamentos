using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; } // creamos la coleccion donde guardaremos las mascotas
        public HelperMascotas() 
        {
            this.Mascotas = new List<Mascota>();// creamos la coleccion 
        }
        //metodo para guardar las mascotas => nombre y raza
        public async Task SaveFileMascotasAsync(string path) //el task porque es asincrono 
        {
            String data = this.GetMascotasString();
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText()) 
            {
                await writer.WriteAsync(data);
                await writer.FlushAsync();
                writer.Close();
            }
        }

        public void ReadFileMascotas(string path) 
        {
            FileInfo file = new FileInfo(path);
            using (TextReader reader = file.OpenText()) 
            {
                String data = reader.ReadToEnd(); // leemos el fichero
                reader.Close(); // cerramos el fichero 
                this.CreateMascotas(data);//pasamos el contenido del fichero al metodo para que nos cree las mascotas
            }
        }
        private String GetMascotasString() 
        {
            //nombre,raza@nombre,raza 
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                //nombre,raza
                String temp = mascota.Nombre + "," + mascota.Raza;
                data += temp + "@";
            }
            data = data.Trim('@');//quitamos la ultima @
            return data;
        }


        private void CreateMascotas(string data) //clase privada para usarla en esta clase 
        {
            //nombre,raza@nombre,raza 
            this.Mascotas.Clear();//limpiamos la coleccion 
            String[] datosmascotas = data.Split('@'); // separamos los datos por @ para obtener las mascotas
            foreach (string d in datosmascotas) 
            {
                //nombre,raza
                String[] propiedades = d.Split(','); // separamos el nombre y la raza 
                Mascota mascota = new Mascota();//creamos una mascota para establecer el nombre y la raza
                mascota.Nombre = propiedades[0]; // añadimos el nombre a la mascota
                mascota.Raza = propiedades[1]; //añadimos la raza a la mascota
                this.Mascotas.Add(mascota);//añadimos una mascota a nuestro list de Mascotas
            }
        }
    }
}
