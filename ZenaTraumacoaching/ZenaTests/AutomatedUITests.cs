using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace ZenaTests
{
    [TestClass]
    public class AutomatedUITests : IDisposable
    {
        private readonly IWebDriver _driver;
        public AutomatedUITests()
        {
            _driver = new ChromeDriver();
        }
        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}
