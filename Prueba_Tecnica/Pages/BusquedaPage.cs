using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Tecnica.Pages
{
    public class BusquedaPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public BusquedaPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        private By lugar = By.Id("place-search-input");
        private By botonBuscar = By.Id("search-button");

        public void ingresarLugar(string departamento) 
        {
            wait.Until(driver => driver.FindElement(lugar)).SendKeys(departamento);
        }

        public void buscarOferta() 
        { 
            wait.Until(driver => driver.FindElement(botonBuscar)).Click();
        }
    }
}
