﻿using CreatingReports.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreatingReports.Tests
{
    [TestClass]
    [TestCategory("ContactUsPage")]
    [TestCategory("SampleApp2")]
    public class ContactUsFeature : BaseTest
    {
        [TestMethod]
        [TestProperty("Author", "NikolayAdvolodkin")]
        [Description("Validate that the contact us page opens successfully with a form.")]
        public void TCID2()
        {
            var contactUsPage = new ContactUsPage(Driver);
            contactUsPage.GoTo();
            Assert.IsTrue(contactUsPage.IsLoaded,
                "The contact us page did not open successfully.");
        }

        [TestMethod]
        [TestProperty("Author", "NikolayAdvolodkin")]
        [Description("Validate that the contact us page opens when clicking the Contact Us button.")]
        public void TCID4()
        {
            var homePage = new HomePage(Driver);
            homePage.GoTo();
            Assert.IsTrue(homePage.IsLoaded, "Home page did not open successfully");

            var contactUsPage = homePage.Header.ClickContactUsButton();
            Assert.IsTrue(contactUsPage.IsLoaded, "The contact us page did not open successfully.");
            
        }
    }
}