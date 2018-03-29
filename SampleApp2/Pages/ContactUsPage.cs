﻿using OpenQA.Selenium;

namespace SampleApp2
{
    internal class ContactUsPage : BaseApplicationPage
    {
        public ContactUsPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsLoaded
        {
            get
            {
                try
                {
                    return CenterColumn.Displayed;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
        }

        public IWebElement CenterColumn => Driver.FindElement(By.Id("center_column"));

        internal void GoTo()
        {
            Driver.Navigate().
                GoToUrl("http://automationpractice.com/index.php?controller=contact");
        }
    }
}