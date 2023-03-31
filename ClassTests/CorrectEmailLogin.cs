using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using FluentAssertions;

namespace AutomatedTesting.ClassTests
{
    public class CorrectEmailLogin : IDisposable
    {
        
        private readonly IWebDriver driver;

        public CorrectEmailLogin()
        {
            driver = new ChromeDriver();

        }

        [Fact]
        public void CorrectUsernamePasswordTest()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

            driver.FindElement(By.Id("username")).SendKeys("tomsmith");
            driver.FindElement(By.Id("password")).SendKeys("SuperSecretPassword!");

            driver.FindElement(By.ClassName("radius")).Click();
            driver.FindElement(By.CssSelector("#flash.success")).Click();

            driver.WindowHandles.Should().HaveCount(1);




        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}
