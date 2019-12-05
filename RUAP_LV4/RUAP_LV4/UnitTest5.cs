﻿using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RUAP_LV4
{
    [TestClass]
    public class UnitTest5
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            NUnit.Framework.Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheZabLozinkaBezIcegTest()
        {
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='$ US Dollar'])[1]/following::span[2]")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.LinkText("Forgotten Password")).Click();
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
        }
        
    }
}
