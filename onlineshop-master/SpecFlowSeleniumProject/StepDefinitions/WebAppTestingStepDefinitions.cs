using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowSeleniumParallelTest.StepDefinitions
{
    [Binding]
    public class WebAppTestingStepDefinitions
    {

        private ChromeDriver driver;

        [Given(@"I have loded Pizza Selection page")]
        public void GivenIHaveLodedPizzaSelectionPage()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://localhost:44310/");
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            //finding webelement by id
            By details = By.XPath("(//a[contains(text(),'Deatils')])[2]");
            IWebElement Details = driver.FindElement(details);
            Details.Click();

            By cart = By.XPath("//input[@value='Add to Cart']");
            IWebElement Cart = driver.FindElement(cart);
            Cart.Click();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            By order = By.CssSelector(".fas");
            IWebElement Order = driver.FindElement(order);
            Order.Click();

            By checkout = By.LinkText("Process to Checkout");
            IWebElement Checkout = driver.FindElement(checkout);
            Checkout.Click();

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            By name = By.XPath("//input[@id='Name']");
            IWebElement Name = driver.FindElement(name);
            Name.Click();
            Name.SendKeys("Rohan Sharma");

            By number = By.XPath("//input[@id='PhoneNo']");
            IWebElement Number = driver.FindElement(number);
            Number.Click();
            Number.SendKeys("9906073825");

            By address = By.XPath("//input[@id='Address']");
            IWebElement Address = driver.FindElement(address);
            Address.Click();
            Address.SendKeys("Muzaffarpur,Bihar,India");

            By email = By.XPath("//input[@id='Email']");
            IWebElement Email = driver.FindElement(email);
            Email.Click();
            Email.SendKeys("rohan12@gmail.com");

            By date = By.XPath("//input[@id='OrderDate']");
            IWebElement Date = driver.FindElement(date);
            Date.Click();

            By select = By.XPath("//a[contains(text(),'29')]");
            IWebElement Select = driver.FindElement(select);
            Select.Click();

            By placeorder = By.XPath("//input[@value='Place Order']");
            IWebElement Placeorder = driver.FindElement(placeorder);
            Placeorder.Click();
        }

        [Then(@"I should see the Order Confirmation page")]
        public void ThenIShouldSeeTheOrderConfirmationPage()
        {
            Console.WriteLine("Web App Testing Successfull..");
            Console.WriteLine("Joe's Pizza App is working Fine");
        }
    }
}
