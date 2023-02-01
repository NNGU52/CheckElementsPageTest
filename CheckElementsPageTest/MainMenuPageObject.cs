using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace CheckElementsPageTest
{
    class MainMenuPageObject
    {
        IWebDriver driver;

        private readonly By _sortByListButton = By.XPath("//span[@class='nav-top__item-link nav-top__item-link-more']");
        private readonly By _allTheSorts = By.XPath("//a[@class='nav-top__item-link']");
        public readonly By _rentButton = By.XPath("//li[@class='nav-top__item']");
        public readonly By _newPageBy = By.XPath("//h1[@class='category-caption__h1']");

        private readonly string rent= "nav-top__item";

        public MainMenuPageObject(IWebDriver webDriver)
        {
            driver = webDriver; 
        }
        
        // 1-й способ нахождения элемента
        public bool CheckElement(string str)
        {
            try
            {
                driver.PageSource.Contains(str);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        // 2-й способ нахождения элемента
        public bool CheckElement_(By locator)
        {
            try
            {
                driver.FindElement(locator);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        // метод выбора вкладки из группы вкладок
        public void ClickOneElementOfSort(string nameSort)
        {
            var sortBy = driver.FindElement(_sortByListButton);
            Actions builder = new Actions(driver);
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,950);");
            builder.MoveToElement(sortBy).Click().Build().Perform();
            var any = driver.FindElements(_allTheSorts).First(x => x.Text == nameSort);
            Thread.Sleep(400);
            any.Click();
        }

        // явное ожидание 
        public void WaitElement(By locator)
        {
            try
            {  
                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new NotFoundException($"Cannot find out that app in specific location: {locator}", ex);
            }
        }


    }
}
