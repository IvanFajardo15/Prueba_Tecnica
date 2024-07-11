using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Tecnica.Pages
{
    public class WelcomePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public WelcomePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        private By colombiaLink = By.Id("Colombialink");

        public void seleccionarColombia() {
            wait.Until(driver => driver.FindElement(colombiaLink)).Click();
        }
    }
}
