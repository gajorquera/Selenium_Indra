using System.Configuration;

namespace Automatizacion.Utilidades
{
    public static class ParametrosEjecucion
    {
        //Variables de la clase

        //Establecer Url de ambiente desde app.config.
        public static string RutaSitio = ConfigurationManager.AppSettings["RutaSitio"];

        //Establecer navegador desde app.config.
        public static string Navegador = ConfigurationManager.AppSettings["Navegador"];

    }
}

