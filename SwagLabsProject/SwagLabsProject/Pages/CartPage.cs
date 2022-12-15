using OpenQA.Selenium;
using SwagLabsProject.Driver;

namespace SwagLabsProject.Pages
{
    public class CartPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement ButtonRemoveBackPack => driver.FindElement(By.Id("remove-sauce-labs-backpack"));
        public IWebElement ButtonRemoveJacket => driver.FindElement(By.Id("remove-sauce-labs-fleece-jacket"));
        public IWebElement ContiniueShopping => driver.FindElement(By.Id("continue-shopping"));
        public IWebElement AssertEmptyBasket => driver.FindElement(By.CssSelector("#shopping_cart_container .shopping_cart_link"));
        public IWebElement ButtonCheckout => driver.FindElement(By.Id("checkout"));
    }
}
