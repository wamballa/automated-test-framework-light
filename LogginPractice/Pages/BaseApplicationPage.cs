﻿using OpenQA.Selenium;

namespace LogginPractice.Pages
{
    public class BaseApplicationPage
    {
        protected IWebDriver Driver { get; set; }
        public BaseApplicationPage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}