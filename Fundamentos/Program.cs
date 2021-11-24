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
            Application.Run(new Form10ValidarISBN());

        }
    }
}
