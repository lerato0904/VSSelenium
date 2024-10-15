using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAutomation.Drivers;
using NUnit.Framework;


namespace UIAutomation.Tests
{
    internal class RegisterUser
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void LaunchPage()
        {
            driver.Navigate().GoToUrl("https://automationexercise.com/");
        }
    }
}
