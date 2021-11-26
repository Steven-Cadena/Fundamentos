using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Direccion
    {
        public Direccion() 
        {
            Debug.WriteLine("constructor Direccion sin parametros");
        }
        //MULTIPLES CONSTRUCTORES Y FROMAS DE CREAR UN OBJETO 
        public Direccion(string calle, string ciudad) 
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor Direccion 2 parametros");
        }
        public Direccion(string calle, string ciudad, int cp)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("Constructor Direccion 3 parametros");
        }

        public String Calle {get;set;}
        public String Ciudad { get; set; }
        public int CodigoPostal { get; set; }
    }
}
