using SwagLabsProject.Driver;
using SwagLabsProject.Pages;

namespace SwagLabsProject.Tests
{
    public class TotalPriceTest
    {
        LoginPage loginPage;
        ProductPage productPage;
        CartPage cartPage;
        InfoPage infoPage;
        CheckoutPage checkoutPage;

        [SetUp]
        public void SetUp()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            productPage = new ProductPage();
            cartPage = new CartPage();
            infoPage = new InfoPage();
            checkoutPage = new CheckoutPage();
        }
        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();
        }
        [Test]
        public void TC01_CheckItemTotalValue_ValueShouldBeConfirmerd()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.AddBackPack.Click();
            productPage.AddBikeLigt.Click();
            productPage.Add_BoltTshirt.Click();
            productPage.ButtonCart.Click();
            cartPage.ButtonCheckout.Click();
            infoPage.FirstName.SendKeys("Marko");
            infoPage.LastName.SendKeys("Manojlovic");
            infoPage.ZipCode.SendKeys("11000");
            infoPage.ButtonContinue.Submit();

            Assert.That("Item total: $55.97", Is.EqualTo(checkoutPage.ItemTotal.Text));
        }
        [Test]
        public void TC02_CheckTotalValue_TotalValueShouldBeConfirmed()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.AddFleeceJacket.Click();
            productPage.Add_Tshirt.Click();
            productPage.AddRedTest_Tshirt.Click();
            productPage.ButtonCart.Click();
            cartPage.ButtonCheckout.Click();
            infoPage.FirstName.SendKeys("Marko");
            infoPage.LastName.SendKeys("Manojlovic");
            infoPage.ZipCode.SendKeys("11000");
            infoPage.ButtonContinue.Submit();

            Assert.That("Total: $79.89", Is.EqualTo(checkoutPage.Total.Text));
        }
    }
}
