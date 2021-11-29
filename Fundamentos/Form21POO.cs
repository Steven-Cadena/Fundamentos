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
            this.lstPropiedades.Items.Clear();
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

        private void btnInstanciarEmpleado_Click(object sender, EventArgs e)
        {
            this.lstPropiedades.Items.Clear();
            Empleado empleado = new Empleado();
            empleado.Nombre = "Empleado";
            empleado.Apellidos = "Net Core";
            this.lstPropiedades.Items.Add("Empleado: " 
                + empleado.GetNombreCompleto());
            this.lstPropiedades.Items.Add("Salario Minimo: "
                 + empleado.GetSalarioMinimo());
            this.lstPropiedades.Items.Add("Días de vacaciones: "
                + empleado.GetDiasVacaciones());

        }

        private void btnInstanciarDirector_Click(object sender, EventArgs e)
        {
            this.lstPropiedades.Items.Clear();
            Director director = new Director();
            director.Nombre = "M.";
            director.Apellidos = "Rajoy";
            this.lstPropiedades.Items.Add("Director: " 
                + director.GetNombreCompleto());
            this.lstPropiedades.Items.Add("Salario Minimo: " 
                + director.GetSalarioMinimo());
            this.lstPropiedades.Items.Add("Días de vacaciones: "
                + director.GetDiasVacaciones());
        }
    }
}
