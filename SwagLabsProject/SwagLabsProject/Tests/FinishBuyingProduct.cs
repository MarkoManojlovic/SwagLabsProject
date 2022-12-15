using SwagLabsProject.Driver;
using SwagLabsProject.Pages;

namespace SwagLabsProject.Tests
{
    public class FinishBuyingProduct
    {
        LoginPage loginPage;
        ProductPage productPage;
        CartPage cartPage;
        InfoPage infoPage;
        CheckoutPage checkoutPage;
        FinishPage finishPage;

        string Message = "THANK YOU FOR YOUR ORDER";

        [SetUp]

        public void SetUp()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            productPage = new ProductPage();
            cartPage = new CartPage();
            infoPage = new InfoPage();
            checkoutPage = new CheckoutPage();
            finishPage = new FinishPage();
        }
        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();
        }
        [Test]
        public void TC01_FinishBuyingProduct_ShouldBeSuccessfully()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.AddBikeLigt.Click();
            productPage.AddBackPack.Click();
            productPage.AddFleeceJacket.Click();
            productPage.Add_Tshirt.Click();
            productPage.Add_BoltTshirt.Click();
            productPage.AddRedTest_Tshirt.Click();
            productPage.ButtonCart.Click();
            cartPage.ButtonCheckout.Click();
            infoPage.FirstName.SendKeys("Marko");
            infoPage.LastName.SendKeys("Manojlovic");
            infoPage.ZipCode.SendKeys("11000");
            infoPage.ButtonContinue.Submit();
            checkoutPage.ButtonFinish.Click();

            Assert.That(Message, Is.EqualTo(finishPage.AssertFinish.Text));
        }
    }
}
