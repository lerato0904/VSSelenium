using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Net;

namespace VSeleniumAutomation
{
    public class Tests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://automationexercise.com/");
           
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Dispose();
            }
        }
    }
}