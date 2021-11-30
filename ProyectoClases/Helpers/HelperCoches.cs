using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperCoches
    {
        public CochesCollection Coches { get; set; }

        public HelperCoches() 
        {
            this.Coches = new CochesCollection();
        }



    }
}
