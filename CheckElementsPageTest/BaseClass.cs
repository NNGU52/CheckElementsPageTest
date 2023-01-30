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
    class BaseClass
    {
        protected IWebDriver driver;

        [OneTimeSetUp]
        protected void DoBeforeAllTheTests()
        {
            
        }

        [OneTimeTearDown]
        protected void DoAfterAllTheTests()
        {
            
        }

        [SetUp]
        protected void DoBeforeEach()
        {

        }

        [TearDown]
        protected void DoAfterEach()
        {
            
        }

    }
}
