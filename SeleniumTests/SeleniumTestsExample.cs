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
            driver = new ChromeDriver("/Users/miroslavkubus/Projects");
        }

        [Test]
        public void OrderProcessTest()
        {
            driver.Url = "https://www.saucedemo.com";

            driver.FindElement(By.Name("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Name("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Name("login-button")).Submit();

            // Add first product to cart
            driver.FindElement(By.Name("add-to-cart-sauce-labs-backpack")).Click();
            Assert.AreEqual("1", driver.FindElement(By.ClassName("shopping_cart_badge")).Text);

            // Add second product to cart
            driver.FindElement(By.Name("add-to-cart-sauce-labs-bike-light")).Click();
            Assert.AreEqual("2", driver.FindElement(By.ClassName("shopping_cart_badge")).Text);

            // Redirect to cart
            driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            Assert.That(driver.FindElements(By.ClassName("cart_item")).Count == 2);

            // Go to checkout
            driver.FindElement(By.Name("checkout")).Click();

            // Fill details
            driver.FindElement(By.Name("firstName")).SendKeys("John");
            driver.FindElement(By.Name("lastName")).SendKeys("Doe");
            driver.FindElement(By.Name("postalCode")).SendKeys("60200");
            driver.FindElement(By.Name("continue")).Click();

            // Assert Checkout page
            Assert.AreEqual("SauceCard #31337", driver.FindElements(By.ClassName("summary_value_label")).ElementAt(0).Text);
            Assert.AreEqual("Free Pony Express Delivery!", driver.FindElements(By.ClassName("summary_value_label")).ElementAt(1).Text);
            Assert.AreEqual("Total: $43.18", driver.FindElement(By.ClassName("summary_total_label")).Text);

            // Finish Order
            driver.FindElement(By.Name("finish")).Click();
            Assert.True(driver.FindElement(By.ClassName("complete-header")).Displayed);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }

}