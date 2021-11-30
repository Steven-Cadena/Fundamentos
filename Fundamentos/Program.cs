using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Form02SumarNumeros());
            //Application.Run(new Form03ColorPosicion());
            //Application.Run(new Form04DiaNacimiento());
            //Application.Run(new Form05ClaseDateTime());
            //Application.Run(new Form06ClaseChar());
            //Application.Run(new Form07ValidarMail());
            //Application.Run(new Form08SumarNumerosString());
            //Application.Run(new Form09InvertirTextStringBuilder());
            //Application.Run(new Form10ValidarISBN());
            //Application.Run(new Form11ColeccionGrafica());
            //Application.Run(new Form12SeleccionMultipleColeccion());
            //Application.Run(new Form13ColeccionNumeros());
            //Application.Run(new Form14TiendaProductos());
            //Application.Run(new Form15EjemploMetodos());
            //Application.Run(new Form16ColeccionArrayList());
            //Application.Run(new Form17ColeccionList());
            //Application.Run(new Form18SumarNumeros());
            //Application.Run(new Form19TablaMultiplicar());
            //Application.Run(new Form20ListaMeses());
            //Application.Run(new Form21POO());
            //Application.Run(new Form22EjemploClases());
            //Application.Run(new Form24FilesNombres());
            //Application.Run(new Form25FicherosMascotas());
            //Application.Run(new Form26SerializationObject());
            Application.Run(new Form27SerializationList());

            
        }
    }
}
