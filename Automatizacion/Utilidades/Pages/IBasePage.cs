using OpenQA.Selenium;

namespace Automatizacion.Utilidades.Pages
{
    /// <summary>
    /// Constructores
    /// </summary>
    public interface IBasePage
    {
        ///Introducir valores al elemento
        void EnviarValor(IWebElement element, string keys);

        ///Valida Formulario
        void ValidarFormulario(IWebElement element);

        ///Puslar Boton
        void PulsarBoton(IWebElement element);

    }
      
}