using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    //herencia director hereda de empleado
    public class Director:Empleado
    {
        public Director() 
        {
            this.SalarioMinimo += 200;
        }

        //OVERRIDE => en la clase de la que vengamos hay que incluir virutal en ese metodo
        //usamos new para decirle que estamos sobrescribiendo
        //el método, nunca leera el metodo anterior, sin embargo los constructores si
        public  override int GetDiasVacaciones() 
        {
            Debug.WriteLine("GetDiasVacaciones() DIRECTOR");
            //para llamar al metodo superior el del padre
            int dias = base.GetDiasVacaciones(); 
            return dias + 8;
        }
    }
}
