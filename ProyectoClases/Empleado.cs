using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    //herencia se declara con : 
    public class Empleado : Persona
    {
        public virtual int GetDiasVacaciones() 
        {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }
        //ponemos la propiedad protected par que solo se pueda acceder desde aqui
        protected int SalarioMinimo{get; set;}
        //metodo para que el formulario pueda acceder a ello 
        //pero no pueda dibujarlo
        public int GetSalarioMinimo() 
        {
            return this.SalarioMinimo;
        }
        //constructores
        public Empleado() :base("otro","Constructor")
        {
            Debug.WriteLine("Constructor Empleado vacio");
            this.SalarioMinimo = 800;
        }
        public Empleado(string nombre, string apellidos)
        {
            Debug.WriteLine("Constructor EMPLEADO con párametros");
            this.SalarioMinimo = 800;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
        
    }
}
