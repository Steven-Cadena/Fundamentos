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
    public partial class Form17ColeccionList : Form
    {
        //el contador ira al nivel de clase 
        //aquí nunca irá un new
        int contador;
        List<Button> botones;
        public Form17ColeccionList()
        {
            InitializeComponent();
            this.contador = 0;
            this.botones = new List<Button>();
            //botones.Add(this.button1);
            //botones.Add(this.button2);
            //botones.Add(this.button3);
            //ESTO RECORRE TODOS LOS CONTROLES DEL FORMULARIO
            foreach (Control control in this.Controls) //importante this.Controls
            {
                if (control is Button) 
                {
                    //hay que convertirlo a button
                    //ya que la list botones espera un boton
                    this.botones.Add((Button)control);
                }
            }

            //botones.Add(this.textBox1);
            //la abstraccion se hace en el type de la coleccion 
            foreach (Button btn in botones) 
            {
                btn.BackColor = Color.Green;
                btn.Click += IncrementarContador;
            }
        }

        private void IncrementarContador(object sender, EventArgs e)
        {

            this.contador += 1;
            //hay que convertir el object sender en button para acceder a sus metodos
            String name = ((Button)sender).Name;
            this.textBox1.Text = name + " Contador: " + this.contador;
        }
    }
}
