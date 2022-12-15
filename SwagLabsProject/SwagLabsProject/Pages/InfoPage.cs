using OpenQA.Selenium;
using SwagLabsProject.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabsProject.Pages
{
    internal class InfoPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement FirstName => driver.FindElement(By.Id("first-name"));
        public IWebElement LastName => driver.FindElement(By.Id("last-name"));
        public IWebElement ZipCode => driver.FindElement(By.Id("postal-code"));
        public IWebElement ButtonContinue => driver.FindElement(By.Id("continue"));

    }
}
