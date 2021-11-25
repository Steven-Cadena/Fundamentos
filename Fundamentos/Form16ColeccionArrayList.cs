using System;
using System.Collections;
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
    public partial class Form16ColeccionArrayList : Form
    {
        public Form16ColeccionArrayList()
        {
            InitializeComponent();
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            //AÑADIMOS LA CAJA A LA COLECCION
            coleccion.Add(this.textBox1);

            //QUEREMOS CAMBIAR EL COLOR AL PRIMER ELEMENTO DE LA COLECCION
            //((Button)coleccion[0]).BackColor = Color.Green;
            //aqui aplicariamos el color nuevo a todos los botones
            foreach (Control control in coleccion) 
            {
                //LOGICAMENTE PODEMOS PREGUNTAR POR TIPOS DEFINIDOS EN EL OBJETO
                //si es de tipo texbox lo pinta de otro color
                if (control is TextBox)
                {
                    control.BackColor = Color.Red;
                    //TEXTBOX TIENE UN METODO LLAMADA Paste()
                    //QUE PEGA LO QUE NOSOTROS TENGAMOS EN EL PORTAPAPELES
                    //quiero pegar el contenido en la caja
                    //debemos hacer el casting a su forma para aplicar dichos métodos
                    ((TextBox)control).Paste();
                }
                else 
                {
                    control.BackColor = Color.Yellow;
                }
            }
        }
    }
}
