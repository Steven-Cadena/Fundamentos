using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{

    public enum TipoGenero { Femenino, Masculino }
    public enum Paises { España, Italia, Polonia, Argentina, Ecuador, Colombia }
    public class Persona//hay que poner publis para que la usen otras clases
    {
        //constructores
        public Persona() 
        {
            Debug.WriteLine("Constructor Persona vacio");
        }
        public Persona(string nombre, string apellidos) 
        {
            Debug.WriteLine("Constructor PERSONA con párametros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
        #region PROPIEDADES DE LA CLASE 
        public Direccion Domicilio {get;set;}
        //esto lo podemos hacer cuando nos da igual lo que el usuario inserte en esa propiedad
        public String Nombre { get; set; }

        public String Apellidos { get; set; }
        //LAS PROPIEDADES SON DE ALGUN TIPO ....
        public TipoGenero Genero { get; set; }
        public Paises Nacionalidad { get; set; }
        //LAS PROPIEDADES TRABAJA CON CAMPOS PRIVADOS QUE MANEJAN
        //LA PROPIEDAD, LA PROPIEDAD ES PUBLICA, PERO YO CON EL CAMPO
        //PRIVADO DECIDO QUE HACER (ES MIO)
        private int _Edad;
        public int Edad
        {
            get
            {
                return this._Edad;
            }
            set
            {
                if (value < 0)
                {
                    //this._Edad = 1;
                    //excepcion
                    throw new Exception("El valor de la edad no puede ser negativo.");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }

        #endregion
        #region Metodos de la Clase 

        //METODOS CON PARAMETROS OPCIONALES
        public void MetodoParametroOpcional(int numero, int parametroopcional = 77)
        {

        }
        //SOBRECARGA DE METODOS 
        public String GetNombreCompleto() 
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public String GetNombreCompleto(bool orden) 
        {
            //PODEMOS LLAMAR ENTRE FORMAS SIN PROBLEMAS 
            //NO DEJAN DE SER OTRO METODO DE LA CLASE
            if (orden == true)
            {
                return this.Apellidos + " " + this.Nombre;
            }
            else 
            {
                return this.GetNombreCompleto();
            }
            
        }

        public void GetNombreCompleto(int numero) { }

        public void GetNombreCompleto(String dato) { }
        #endregion
    }
}
