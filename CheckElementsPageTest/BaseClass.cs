using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Interactions;


namespace CheckElementsPageTest
{
    public class BaseClass
    {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void DoBeforeAllTheTests()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
        }

        [SetUp]
        protected void DoBeforeEach()
        {
            driver.Navigate().GoToUrl(TestSettings.HostPrefix);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        protected void DoAfterEach()
        {
          driver.Quit();
        }

    }
}
