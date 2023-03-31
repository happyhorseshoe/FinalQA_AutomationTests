using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomatedTesting.ClassTests
{
    public class NegativeEmailLogin : IDisposable
    {
        private readonly IWebDriver driver;

        public NegativeEmailLogin()
        {
            driver = new ChromeDriver();

        }

        [Fact]
        public void InvalidUsernameTest()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            driver.FindElement(By.Id("username")).SendKeys("invalid");
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();

            Assert.Contains("Your username is invalid", driver.PageSource);
        }


        public void Dispose()
        {
            driver.Quit();
        }
    }
}

