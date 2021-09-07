using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatizacion.Utilidades
{
    //Excepciones dentro de las pruebas
   public class ExcepcionPrueba : Exception
    {
        //Constructor de la clase sin parametros.
        public ExcepcionPrueba()
        {

        }

        //Constructor de la clase con un parametro.
        public ExcepcionPrueba(string message)
            : base(message)
        {

        }

        //Constructor de la clase con dos parametros.
        public ExcepcionPrueba(string message, Exception inner)
            :base (message, inner)
        {

        }
    }
}
