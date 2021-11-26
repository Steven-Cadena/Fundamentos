using ProyectoClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form21POO : Form
    {
        public Form21POO()
        {
            InitializeComponent();
        }

        private void btnInstanciarPersona_Click(object sender, EventArgs e)
        {
            Persona person = new Persona();
            person.Nombre = "Alumno Net";
            person.Apellidos = "Core";
            person.Edad = 26;
            //llamamos a la clase para poder acceder a esas propiedades
            //person.Domicilio = new Direccion();
            //person.Domicilio.Calle = "Calle Pez";

            //con  2 parametros
            //person.Domicilio = new Direccion("Calle Pez", "Valencia");
            //con  3 parametros
            person.Domicilio = new Direccion("Calle Pez", "Valencia",28546);
            person.Genero = TipoGenero.Masculino;
            person.Nacionalidad = Paises.Polonia;
            //metodos parametros
            person.MetodoParametroOpcional(7);
            person.MetodoParametroOpcional(7,22);
            person.MetodoParametroOpcional(22, parametroopcional: 85);
            this.lstPropiedades.Items.Add("GetNombreCompleto(): "
                + person.GetNombreCompleto(true));
            this.lstPropiedades.Items.Add("Nombre: " + person.Nombre);
            this.lstPropiedades.Items.Add("Edad: " + person.Edad);
            this.lstPropiedades.Items.Add("Nacionalidad: " + person.Nacionalidad);
            this.lstPropiedades.Items.Add("Genero: " + person.Genero);
            this.lstPropiedades.Items.Add("Domicilio: " + person.Domicilio.Calle);
        }
    }
}
