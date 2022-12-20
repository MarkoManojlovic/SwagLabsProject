using OpenQA.Selenium;
using SwagLabsProject.Driver;

namespace SwagLabsProject.Pages
{
    public class CheckoutPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement ItemTotal => driver.FindElement(By.ClassName("summary_subtotal_label"));
        public IWebElement Tax => driver.FindElement(By.ClassName("summary_tax_label"));
        public IWebElement Total => driver.FindElement(By.ClassName("summary_total_label"));
        public IWebElement ButtonFinish => driver.FindElement(By.Id("finish"));
    }
}
