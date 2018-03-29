﻿using OpenQA.Selenium;

namespace SampleFramework1
{
    public class UltimateQAHomePage : BaseSampleApplicationPage
    {
        public UltimateQAHomePage(IWebDriver driver) : base(driver){}

        public bool IsVisible {
            get
            {
                try
                {
                    return StartHereButton.Displayed;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
        }

        public IWebElement StartHereButton => Driver.FindElement(By.LinkText("Start here"));
    }
}