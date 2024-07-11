using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Tecnica.Pages
{
    public class ResultadoOfertasPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        
        public ResultadoOfertasPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver,TimeSpan.FromSeconds(5));
        }

        private By aceptarAlerta = By.CssSelector("button[onclick='webpush_subscribe_ok(event);']");
        private By categoria = By.Id("prof-cat-search-input");
        private By filtroSalario = By.XPath("//p[text() = 'Salario']");
        private By lista = By.ClassName("buildLink");
        private By filtroExperiencia = By.XPath("//p[text() = 'Experiencia']");
        private By experiencia = By.ClassName("buildLink");
        private By oferta = By.ClassName("js-o-link");
        private By nombreOferta = By.ClassName("title_offer");
        private By bloqueDepartamento = By.CssSelector("div[data-id = '7A797577CC74F11161373E686DCF3405']");
        private By departamento = By.ClassName("mb5");
        private By acciones = By.XPath("//article[@data-id='7A797577CC74F11161373E686DCF3405']/div[@class='opt_dots']");
        private By botonPostular = By.XPath("//article[@data-id='7A797577CC74F11161373E686DCF3405']/div[@class='opt_dots']/div[1]/a[1]/span[1]");
        private By textCorreo = By.Id("LoginModel_Email");
        private By botonContinuar= By.Id("continueWithMailButton");

        public void aceptarAlertas()
        {
            try { 
            wait.Until(driver => driver.FindElement(aceptarAlerta)).Click();
            }
            catch (ElementNotInteractableException ex)
            {
                Console.WriteLine($"Error interactuando con la notificación de alertas: {ex.Message}");
            }
        }

        public void registrarCargo(String cargo) 
        {
            wait.Until(driver => driver.FindElement(categoria)).SendKeys(cargo);
        }

        public void desplegarSalario() 
        {
            wait.Until(driver => driver.FindElement(filtroSalario)).Click();
        }

        public void filtrarSalario() {
            IList<IWebElement> listSalario = driver.FindElements(lista);
            foreach (WebElement option in listSalario) 
            {
                if (option.Text == "Menos de $ 700.000") 
                {
                    option.Click();
                    break;
                }
            }
        }

        public void desplegarExperiencia() 
        {
            wait.Until(driver => driver.FindElement(filtroExperiencia)).Click();
        }

        public void filtrarExperiencia()
        {
            IList<IWebElement> listExperiencia = driver.FindElements(experiencia);
            foreach (IWebElement option in listExperiencia)
            {
                if (option.Text == "1 año")
                {
                    option.Click();
                    break;
                }
            }
        }

        public void seleccionarOferta()
        {
            IList<IWebElement> listOfertas = wait.Until(driver => driver.FindElements(oferta));
            foreach (IWebElement option in listOfertas)
            {
                if (option.Text.Contains("Test automation Engineer QA"))
                {
                    option.Click();
                    break;
                }
            }
        }

        public String verificarNombreOferta()
        {
            return wait.Until(driver => driver.FindElement(nombreOferta)).Text;
        }

        public String verificarDepartamento()
        {
            return wait.Until(driver => driver.FindElement(bloqueDepartamento).FindElement(departamento)).Text;
        }

        public void accionOferta()
        {
            wait.Until(driver => driver.FindElement(acciones)).Click();
        }

        public void postular() 
        {
            wait.Until(driver => driver.FindElement(botonPostular)).Click();
        }

        public void registrarCorreo(String correo)
        {
            wait.Until(driver => driver.FindElement(textCorreo)).SendKeys(correo);
        }

        public void continuarRegistro()
        {
            wait.Until(driver => driver.FindElement(botonContinuar)).Click();
        }
    }
}
