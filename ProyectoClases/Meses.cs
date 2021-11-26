using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Meses
    {
        public Meses(string mes, int tempMax, int tempMin) 
        {
            this.Mes = mes;
            this.TemperaturaMaxima = tempMax;
            this.TemperaturaMinima = tempMin;
        }

        public String Mes { get; set; }
        public int TemperaturaMaxima { get; set;}
        public int TemperaturaMinima { get; set;}
        public int _MediaMensual { get; set; }
    }
}
