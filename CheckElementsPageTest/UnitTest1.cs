using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System;

namespace CheckElementsPageTest
{
    [TestFixture]
    public class Tests : BaseClass
    {
        [Test]
        public void Test1()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);

            mainMenu.WaitElement(mainMenu._rentButton);
            mainMenu.ClickOneElementOfSort(NameSorts.ByBusinessSort);
            mainMenu.WaitElement(mainMenu._newPageBy);
        }
    }
}