using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SwagLabsProject.Driver;

namespace SwagLabsProject.Pages
{
    public class ProductPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement SortByPrice => driver.FindElement(By.ClassName("product_sort_container"));
        public IWebElement Add_Tshirt => driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie"));
        public IWebElement AddBikeLigt => driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        public IWebElement Add_BoltTshirt => driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        public IWebElement AssertForCart => driver.FindElement(By.CssSelector("#shopping_cart_container .shopping_cart_badge"));
        public IWebElement ButtonCart => driver.FindElement(By.Id("shopping_cart_container"));
        public IWebElement AddBackPack => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        public IWebElement AddFleeceJacket => driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket"));
        public IWebElement AddRedTest_Tshirt => driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)"));

        public void SelectOption(string text)
        {
            SelectElement element = new SelectElement(SortByPrice);
            element.SelectByText(text);
        }
    }
}
