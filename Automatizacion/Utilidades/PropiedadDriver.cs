using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automatizacion.Utilidades
{
    public static class PropiedadDriver
    {

        //Establecer objeto Web Driver
        public static IWebDriver Driver;

        //Metodos de la clase
        //Cargar web driver
        public static void CargarDriver()
        {
            try
            {
                switch (ParametrosEjecucion.Navegador)
                {
                    case "Chrome":
                        Driver = new ChromeDriver();
                        break;

                    case "Firefox":
                        Driver = new FirefoxDriver();
                        break;

                    case "Explorer":
                        Driver = new InternetExplorerDriver();
                        break;

                    default:
                        throw new ExcepcionPrueba(ParametrosEjecucion.Navegador + "NO ES COMPATIBLE");
                }
            }
            catch (Exception)
            {
                throw new Exception("EL NAVEGADOR NO SE HA CARGADO");
            }
        }

        //obtener WebDriver
        public static IWebDriver ObtenerDriver
        {
            get
            {
                try
                {
                    if(Driver == null)
                    {
                        CargarDriver();
                    }
                    return Driver;
                }
                catch (ExcepcionPrueba)
                {
                    throw new ExcepcionPrueba("Driver no ha cargado");
                }
            }
        }
      
        //WebDriver espera la cantidad de segundos al encontrar elementos.
        public static WebDriverWait GetDriverWait(int seconds)
        {
            WebDriverWait waitDriver;

            try
            {
                waitDriver = new WebDriverWait(ObtenerDriver, TimeSpan.FromSeconds(seconds));
            }
            catch (Exception)
            {
                throw new Exception("ERROR GRAVE DE CARGA DE DRIVER");
            }

            return waitDriver;
        }
    }
}


