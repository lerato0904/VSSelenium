using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutomation.Drivers
{
    internal class DriverManager
    {
        public static IWebDriver? _driver;

        public static IWebDriver Setup()
        {
            if (_driver == null)
            {
                _driver = new ChromeDriver();
            }
            return _driver;
        }
    }
}
