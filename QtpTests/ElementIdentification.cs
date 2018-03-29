﻿using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace QtpTests
{
    [TestClass]
    public class ElementIdentification : TestBase
    {
        static IWebDriver driver = GetChromeDriver();
        private IWebElement element;
        private By locator;

        [TestMethod]
        public void RunTest()
        {
            driver.Navigate().GoToUrl("http://www.qtptutorial.net/automation-practice");

            ////Find an element using an id
            //driver.FindElement(By.Id("idExample"));
            //var idElement = driver.FindElement(By.Id("idExample"));
            //idElement.Click();
            //driver.Navigate().Back();

            ////Find an element using a ClassName
            //element = driver.FindElement(By.ClassName("buttonClassExample"));
            //element.Click();
            //driver.Navigate().Back();

            //////Find an element using Name
            //element = driver.FindElement(By.Name("NameExample"));
            //element.Click();
            //driver.Navigate().Back();

            //////Find an element using Link Text
            //var linkTextElement = driver.FindElement(By.LinkText("Click This Button Using 'ID'"));
            //linkTextElement.Click();
            //driver.Navigate().Back();

            ////Find an element using Partial Link Text
            //var linkTextElementP = driver.FindElement(By.PartialLinkText("Click me"));
            //linkTextElementP.Click();
            //driver.Navigate().Back();

            ////Find an element using Css
            //var cssElement = driver.FindElement(By.CssSelector(".et_pb_promo_button"));
            //cssElement.Click();
            //driver.Navigate().Back();

            //Find an element using Xpath
            //var xpathElement = driver.FindElement(By.XPath(".//*[@id='post-5969']/div/div[2]/div/div[1]/div[2]/a"));
            //xpathElement.Click();
            //driver.Navigate().Back();

            ////Click a radio button using the button order
            //locator = By.XPath("//input[@name='selection'][1]");
            //element = driver.FindElement(locator);
            //element.Click();

            ////Click a radio button using the text
            //locator = By.XPath("//input[@value='I love HP UFT']");
            //element = driver.FindElement(locator);
            //element.Click();

            //////Find a radio button list
            //By byXpath = By.XPath("//input[@type='radio']");
            //IList<IWebElement> elements = driver.FindElements(byXpath);

            ////////Working with HTML tables
            ////////How can you get the whole html table into an object?
            //locator = By.Id("htmlTableId");
            //var table = driver.FindElement(locator);

            //////how can you get a collection of all the rows in the table?
            //IList<IWebElement> collectionOfRows = table.FindElements(By.XPath("//*[@id='htmlTableId']/tbody/tr"));


            //////Using Selenium: What is the Salary of an SDET?
            //var columnIndex = -1;
            //var columnCounter = 1;
            //const string DESIRED_COLUMN_HEADER = "Salary";
            //const string DESIRED_VALUE = "Software Development Engineer in Test";

            //for (int tr = 0; tr <= collectionOfRows.Count; tr++)    //for every single row in the table
            //{
            //    var row = collectionOfRows[tr];

            //    IList<IWebElement> allCellsInRow = row.FindElements(By.XPath("./*"));
            //    foreach (var cell in allCellsInRow)
            //    {
            //        if (cell.Text == DESIRED_COLUMN_HEADER)
            //        {
            //            columnIndex = columnCounter;
            //        }

            //        if (cell.Text == DESIRED_VALUE)
            //        {
            //            //.//*[@id='htmlTableId']/tbody/tr[2]/td[3]
            //            string salaryLocator = string.Format(".//*[@id='htmlTableId']/tbody/tr[{0}]/td[{1}]", tr + 1, columnIndex);
            //            var salary = driver.FindElement(By.XPath(salaryLocator));
            //            Console.WriteLine("The {0} of {1} is {2}", DESIRED_COLUMN_HEADER, DESIRED_VALUE, salary.Text);
            //        }
            //        columnCounter++;
            //    }
            //}

            ////How do you get an html table that has no id?
            locator = By.TagName("table");
            IList<IWebElement> tables = driver.FindElements(locator);
        }
        private static IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
