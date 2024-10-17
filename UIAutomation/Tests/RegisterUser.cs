using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Bogus;
using UIAutomation.Drivers;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.BiDi.Modules.Input;


namespace UIAutomation.Tests
{
    internal class RegisterUser
    {
        public IWebDriver driver;
        Faker faker;

        public RegisterUser()
        {
            faker = new Faker();
            driver = DriverManager.Setup();
        }

        public void NavigateToURL()
        {
            driver.Navigate().GoToUrl("https://automationexercise.com/");
            driver.Manage().Window.Maximize();
        }

        public void VerifyHomePageIsVisible()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver =>
            ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").ToString() == "complete"
            );

            var homePageText = driver.FindElement(By.XPath("//*[@id=\"header\"]/div/div/div/div[1]/div/a/img"));
            Assert.IsNotNull(homePageText);
        }

        public void ClickOnSignUpButton()
        {
            var signUpButton = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[4]/a");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(signUpButton));
            clickableElement.Click();
           
        }

        public string EnterSignUpUserName()
        {
            string name = faker.Name.FirstName();

            var nameInputBox = By.XPath("//*[@id=\"form\"]/div/div/div[3]/div/form/input[2]");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(nameInputBox));


            driver.FindElement(By.XPath("//*[@id=\"form\"]/div/div/div[3]/div/form/input[2]")).SendKeys(name);

            return name;
        }

        public void EnterEmail()
        {
            string email = faker.Name.FirstName() + "@test.com";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var emailInputBox = By.XPath("//*[@id=\"form\"]/div/div/div[3]/div/form/input[3]");
   
            IWebElement clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(emailInputBox));


            clickableElement.SendKeys(email);
        }

        public void ClickSignUpButton()
        {
            var signUpButton = By.XPath("//*[@id=\"form\"]/div/div/div[3]/div/form/button");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(signUpButton));
            clickableElement.Click();            
        }

        public void ConfirmuserIsSignedUp()
        {
            Actions scrolldown = new Actions(driver);
            scrolldown.SendKeys(Keys.PageDown).Perform();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            wait.Until(driver =>
            ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").ToString() == "complete"
            );

            var accountInfoText = driver.FindElement(By.XPath("//*[@id=\"form\"]/div/div/div/div[1]/h2/b"));
            Assert.IsNotNull(accountInfoText);
            Assert.AreEqual("ENTER ACCOUNT INFORMATION", accountInfoText.Text);
        }
    }
}
