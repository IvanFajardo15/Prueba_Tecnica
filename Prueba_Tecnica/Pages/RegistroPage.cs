using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Tecnica.Pages
{
    public class RegistroPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        public RegistroPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        private By textName = By.Id("Name");
        private By textLastName = By.Id("SurName");
        private By textPassword = By.Id("Password");
        private By textCargo = By.Id("Cargo");
        private By departamentoList = By.ClassName("option");
        private By textCaptcha = By.Id("CaptchaInputText");
        private By botonContinuar = By.Id("continueButton");
        private By mensajeError = By.ClassName("field-validation-error");

        public void registrarNombre(String nombre)
        {
            wait.Until(driver => driver.FindElement(textName)).SendKeys(nombre);
        }

        public void registrarApellido(String apellido)
        {
            wait.Until(driver => driver.FindElement(textLastName)).SendKeys(apellido);
        }

        public void registrarPassword(String password)
        {
            wait.Until(driver => driver.FindElement(textPassword)).SendKeys(password);
        }

        public void registrarCargo(String cargo)
        {
            wait.Until(driver => driver.FindElement(textCargo)).SendKeys(cargo);
        }

        public void seleccionarDepartamento(String departamento)
        {
            IList<IWebElement> listDepartamento = driver.FindElements(departamentoList);

            foreach (IWebElement option in listDepartamento)
            {
                if (option.Text == departamento)
                {
                    option.Click();
                }
            }
        }

        public void ingresarCaptcha(String captcha)
        {
            wait.Until(driver => driver.FindElement(textCaptcha)).SendKeys(captcha);
        }

        public void clickContinuar()
        {
            wait.Until(driver => driver.FindElement(botonContinuar)).Click();
        }
        
        public IWebElement obtenetError()
        {
            return driver.FindElement(mensajeError);
        }
    }
}

    
