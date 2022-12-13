using SwagLabsProject.Driver;
using SwagLabsProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabsProject.Tests
{
    public class BuyingProductTest
    {
        ProductPage productPage;
        LoginPage loginPage;
        CartPage cartPage;


        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            productPage = new ProductPage();
            cartPage = new CartPage();
        }
        [TearDown]
        
        public void Close()
        {
            WebDrivers.CleanUp();
        }
        [Test]
        public void TC01_ProductSortByLowPriceAndPlacedInBasket()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.SelectOption("Price (low to high)");
            productPage.Add_Tshirt.Click();
            productPage.AddBikeLigt.Click();
            productPage.Add_BoltTshirt.Click();
            Assert.That("3", Is.EqualTo(productPage.AssertForCart.Text));

        }
        [Test]
        public void TC02_RemoveProductFromBasket()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.AddBackPack.Click();
            productPage.AddFleeceJacket.Click();
            productPage.ButtonCart.Click();
            cartPage.ButtonRemoveBackPack.Click();
            cartPage.ButtonRemoveJacket.Click();
            cartPage.ContiniueShopping.Click();
            //Assert.That(cartPage.AssertEmptyBasket.Displayed);
            Assert.That("", Is.EqualTo(cartPage.AssertEmptyBasket.Text));
            

        }
    }
}
