using Automatizacion.Utilidades.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;

//Capa Validacion.
namespace Automatizacion.Pages._01._Transversal._01._Acceso
{

    public class LoginPage
    {
        //BasePage objeto clase.
        public static BasePage basePage;
        //Constructor Basepage
        public LoginPage()
        {
            basePage = new BasePage();

            //Obtiene driver
            PageFactory.InitElements(Utilidades.PropiedadDriver.ObtenerDriver, this); //??
        }
        //Driver de Selenium
        public static IWebDriver Driver;

        //Obtiene driver


        //localizadores Elementos Web
        [FindsBy(How = How.ClassName, Using = "login-form")]
        public IWebElement Form;

        [FindsBy(How = How.Id, Using = "User")]
        public IWebElement txtUser;

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement txtPassword;

        [FindsBy(How = How.Id, Using = "loginButton")]
        public IWebElement btnLogin;

        //Se crean metodos que el WebDriver realiza sobre ellos de la clase BasePage.

        //Metodo para escribir el User y Password
        public void IngresarCredenciales(String User, String Password)
        {
            basePage.EnviarValor(txtUser, User);
            basePage.EnviarValor(txtPassword, Password);
        }

        //Metodo para hacer click en el boton del login
        public void PulsarBotonLogin()
        {
            basePage.PulsarBoton(btnLogin);
        }

        public void ValidarDesplieguePaginaLogin()
        {
            basePage.ValidarFormulario(Form);
        }
    }
}