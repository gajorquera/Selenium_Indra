using OpenQA.Selenium;
using System;


namespace Automatizacion.Utilidades.Pages
{
    public class BasePage : IBasePage
    {

        ///introduce valores al elemento y los envia
        public void EnviarValor(IWebElement element, string keys)
        {
            try
            {
                element.SendKeys(keys);
                element.Click();
            }
            catch (Exception)
            {
                throw new Exception("Error al enviar valor del elemento");
            }
        }

        ///Pulsar boton Log In
        public void PulsarBoton(IWebElement element)
        {
            try
            {
                element.Click();
            }
            catch (Exception)
            {
                throw new Exception("Error al hacer click en el boton");
            }
        }

        ///Valida el formulario de inicio de sesion
        public void ValidarFormulario(IWebElement element)
        {
            try
            {
                element.FindElement(By.ClassName("login-form"));
            }
            catch (Exception)
            {
                throw new Exception("Error al encontrar elemento");
            }

        }
    }
}