using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    public class SeleniumTestsExample
    {
        IWebDriver? driver;

        [SetUp]
        public void startBrowser()
        {
            // TODO: Place here path to you chrome driver
            driver = new ChromeDriver(@"C:\Users\roman.duris\RiderProjects\UITestsKata");
        }

        [Test]
        public void OrderProcessTest()
        {
            driver.Url = "https://www.saucedemo.com";
            
            IWebElement usernameTextBox = driver.FindElement(By.Id("user-name"));
            IWebElement passwordTextBox = driver.FindElement(By.Id("password"));
            IWebElement loginButton = driver.FindElement(By.Id("login-button"));

            usernameTextBox.Clear();
            usernameTextBox.SendKeys("standard_user");
            passwordTextBox.Clear();
            passwordTextBox.SendKeys("secret_sauce");
            loginButton.Click();

            IWebElement sauceLabBackpackButton = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            sauceLabBackpackButton.Click();

            IWebElement carButton = driver.FindElement(By.ClassName("shopping_cart_link"));
            carButton.Click();

            IWebElement checkoutButton = driver.FindElement(By.Id("checkout"));
            checkoutButton.Click();
            
            IWebElement nameTextBox = driver.FindElement(By.Id("first-name"));
            IWebElement surnameTextBox = driver.FindElement(By.Id("last-name"));
            IWebElement postalTextBox = driver.FindElement(By.Id("postal-code"));
            nameTextBox.SendKeys("Roman");
            surnameTextBox.SendKeys("Duris");
            postalTextBox.SendKeys("60200");

            IWebElement continueButton = driver.FindElement(By.Id("continue"));
            continueButton.Click();

            IWebElement finishButton = driver.FindElement(By.Id("finish"));
            finishButton.Click();


        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }

}