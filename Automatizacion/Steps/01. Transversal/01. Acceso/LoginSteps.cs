using Automatizacion.Pages._01._Transversal._01._Acceso;
using System;
using TechTalk.SpecFlow;

namespace Automatizacion.Steps._01._Transversal._01._Acceso
{
    [Binding]
    public class LoginSteps
    {
        //Establecer objeto clase LoginSteps
        private static LoginPage loginPage;
        //Contructor de la clase.
        public LoginSteps()
        {
            loginPage = new LoginPage();
        }
        //Ejecuta pasos y llama a los metodos alamcenados en 

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            loginPage.ValidarDesplieguePaginaLogin();
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(string User, string Password)
        {
            loginPage.IngresarCredenciales(User, Password);
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            loginPage.PulsarBotonLogin();
        }

        [Then(@"the system displays the main page")]
        public void ThenTheSystemDisplaysTheMainPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
