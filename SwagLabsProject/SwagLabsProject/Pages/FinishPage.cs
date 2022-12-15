using OpenQA.Selenium;
using SwagLabsProject.Driver;

namespace SwagLabsProject.Pages
{
    public class FinishPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement AssertFinish => driver.FindElement(By.CssSelector("#checkout_complete_container .complete-header"));
    }
}
