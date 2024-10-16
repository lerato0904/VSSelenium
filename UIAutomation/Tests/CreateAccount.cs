using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

    }
}
