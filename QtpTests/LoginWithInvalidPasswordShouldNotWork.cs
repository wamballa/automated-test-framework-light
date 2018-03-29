﻿using Framework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace QtpTests
{
    [TestClass]
    public class LoginWithInvalidPasswordShouldNotWork : TestBase
    {
        [TestMethod]
        public void RunTest()
        {
            Pages.Login.Goto();
            Pages.Login.Login("seleniumTestUser", "SeleniumRocksMySocks!!");
            Assert.IsFalse(Pages.MyMembership.IsAt());
        }
    }
}
