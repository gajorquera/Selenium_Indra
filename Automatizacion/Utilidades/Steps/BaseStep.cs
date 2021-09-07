using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Automatizacion.Utilidades.Steps
{
    [Binding]
    public sealed class BaseStep
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public ScenarioContext _scenarioContext;

        //Contexto del Scenario(Feature)
        public BaseStep(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        //Logica de Hooks
        [BeforeTestRun]
        public void BeforeTestRun()
        {
            //Reporte
            var htmlReporter = new ExtentHtmlReporter(@"C:\extentreport\seleniumWithSpecflow\SpecflowParallelTest\ExtentReport.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            var extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            //Feature
            var feature = extent.CreateTest<Feature>("Login");
            //Scenario
            var scenario = feature.CreateNode<Scenario>("Login user as Administrator");
            //Steps
            scenario.CreateNode<Given>("I navigate to application");

            extent.Flush();

        }

        public static void BeforeTestRun()
       {
           DriverContext.Initialize();
           Page.Initialize();
       }

        [BeforeFeature]
        public void Beforefeature()
        {
           //Obtiene el nombre del feature para reporte

        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            //Obtiene el nombre del escenario para reporte
            
        }
        
        [AfterStep]
        public void AfterStep()
        {
            //Obtener resultado del paso
            //Genera captura en caso de error
        }
    }
}