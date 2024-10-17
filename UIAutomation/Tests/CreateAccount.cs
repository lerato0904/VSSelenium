using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutomation.Tests
{
    internal class CreateAccount : RegisterUser
    {
        public void ConfirmUserName() 
        {
            var userName = driver.FindElement(By.Id("name"));
            var savedUserName = EnterSignUpUserName();
            Assert.AreEqual(userName, savedUserName);  
        }

        public void SelectGender()
        {
            driver.FindElement(By.Id("id_gender2")).Click();
        }

        public void EnterUserPassword()
        {
            driver.FindElement(By.Id("password")).SendKeys("password1234*");
        }

        public void EnterDayOfBirth()
        {
            driver.FindElement(By.Id("days")).SendKeys("15");
        }

        public void EnterMonthOfBirth()
        {
            driver.FindElement(By.Id("months")).SendKeys("September");
        }

        public void EnterYearOfBirth()
        {
            driver.FindElement(By.Id("years")).SendKeys("1997");
        }

        public void EnterFirstName()
        {
            driver.FindElement(By.Id("first_name")).SendKeys("Lerato");
        }

        public void EnterLastName()
        {
            driver.FindElement(By.Id("last_name")).SendKeys("Radebe");
        }

        public void EnterCompany()
        {
            driver.FindElement(By.Id("company")).SendKeys("Private Company");
        }

        public void EnterAddress()
        {
            driver.FindElement(By.Id("address1")).SendKeys("Address One Two");
        }
        public void EnterAddress2()
        {
            driver.FindElement(By.Id("address2")).SendKeys("Address Two Three");
        }

        public void SelectCountry()
        {
            driver.FindElement(By.Id("country")).SendKeys("South Africa");
        }

        public void EnterState()
        {
            driver.FindElement(By.Id("state")).SendKeys("Gauteng");
        }

        public void EnterCity()
        {
            driver.FindElement(By.Id("city")).SendKeys("Johannesburg");
        }

        public void EnterZipCode()
        {
            driver.FindElement(By.Id("zipcode")).SendKeys("1234");
        }

        public void EnterCellPhoneNumber()
        {
            driver.FindElement(By.Id("mobile_number")).SendKeys("071234567");
        }

        public void ClickOnCreateAccountButton()
        {
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Perform();

            IWebElement createAccount_Button = driver.FindElement(By.XPath("//*[@id=\"form\"]/div/div/div/div[1]/form/button"));
            createAccount_Button.Click();
        }

        public void ConfirmAccountIsCreatedSuccesfully()
        {
            var accountCreatedMessage = driver.FindElement(By.XPath("//*[@id=\"form\"]/div/div/div/h2/b"));
            Assert.AreEqual(accountCreatedMessage.Text, "ACCOUNT CREATED!");
        }
    }
}