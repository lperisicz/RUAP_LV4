﻿using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace RUAP_LV4
{
    [TestClass]
    public class UnitTest6
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--kiosk");
            driver = new ChromeDriver(options);
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

        [Test]
        public void TheRegistracijaNemaPrivoleTest()
        {
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='$ US Dollar'])[1]/following::span[2]")).Click();
            driver.FindElement(By.LinkText("Register")).Click();
            driver.FindElement(By.Id("input-firstname")).Click();
            driver.FindElement(By.Id("input-firstname")).Clear();
            driver.FindElement(By.Id("input-firstname")).SendKeys("qweqwe");
            driver.FindElement(By.Id("input-lastname")).Click();
            driver.FindElement(By.Id("input-lastname")).Clear();
            driver.FindElement(By.Id("input-lastname")).SendKeys("ewqewq");
            driver.FindElement(By.Id("input-email")).Click();
            driver.FindElement(By.Id("input-email")).Clear();
            driver.FindElement(By.Id("input-email")).SendKeys("qweqwe@qwe.qwe");
            driver.FindElement(By.Id("input-telephone")).Click();
            driver.FindElement(By.Id("input-telephone")).Clear();
            driver.FindElement(By.Id("input-telephone")).SendKeys("23132132123");
            driver.FindElement(By.Id("input-password")).Click();
            driver.FindElement(By.Id("input-password")).Clear();
            driver.FindElement(By.Id("input-password")).SendKeys("lozinka562lozinka");
            driver.FindElement(By.Id("input-confirm")).Click();
            driver.FindElement(By.Id("input-confirm")).Clear();
            driver.FindElement(By.Id("input-confirm")).SendKeys("lozinka562lozinka");
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
        }

        [Test]
        public void TheLoginNepostojeciTest()
        {
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='$ US Dollar'])[1]/following::span[2]")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("input-email")).Click();
            driver.FindElement(By.Id("input-email")).Clear();
            driver.FindElement(By.Id("input-email")).SendKeys("sdaijisd@ifdi.comweqqweq");
            driver.FindElement(By.Id("input-password")).Click();
            driver.FindElement(By.Id("input-password")).Clear();
            driver.FindElement(By.Id("input-password")).SendKeys("UXjtdETYmt7e@bM32123123123");
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }

        [Test]
        public void TheLoginOdlazakTest()
        {
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='$ US Dollar'])[1]/following::span[2]")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
        }

        [Test]
        public void TheRegistracijaOdlazakTest()
        {
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='$ US Dollar'])[1]/following::span[2]")).Click();
            driver.FindElement(By.LinkText("Register")).Click();
        }

    }
}
