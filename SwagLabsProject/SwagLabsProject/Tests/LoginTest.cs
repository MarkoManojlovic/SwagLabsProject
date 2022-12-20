using SwagLabsProject.Driver;
using SwagLabsProject.Pages;

namespace SwagLabsProject.Tests
{
    public class Tests
    {
        LoginPage loginPage;
        ProductPage productPage;
        string Message_N01 = "Epic sadface: Username is required";
        string Message_N02 = "Epic sadface: Username and password do not match any user in this service";

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            productPage= new ProductPage();
        }
        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();
        }

        [Test]
        public void TC01_DoNotEnterAnyData_ShouldNotBeLogged()
        {
            loginPage.Login("", "");

            Assert.That(Message_N01, Is.EqualTo(loginPage.AssertMessage.Text));
        }
        [Test]
        public void TC02_EnterInvalidUserName_AndShouldNotBeLogged()
        {
            loginPage.Login("Marko", "secret_sauce");

            Assert.That(Message_N02, Is.EqualTo(loginPage.AssertMessage.Text));
        }
        [Test]
        public void TC03_EnterInvalidPassword_AndShouldNotBeLogged()
        {
            loginPage.Login("standard_user", "marko12345");
            
            Assert.That(Message_N02, Is.EqualTo(loginPage.AssertMessage.Text));
        }
        [Test]
        public void TC04_EnterInvalidUserNameAndPassword_ShouldNotBeLogged()
        {
            loginPage.Login("Marko", "Manojlovic");

            Assert.That(Message_N02, Is.EqualTo(loginPage.AssertMessage.Text));
        }
        [Test]
        public void TC05_EnterValidUserNameAndPassword_ShouldBeLogged()
        {
            loginPage.Login("standard_user", "secret_sauce");

            Assert.That("https://www.saucedemo.com/inventory.html", Is.EqualTo(productPage.ProductPageUrl));
        }
    }
}