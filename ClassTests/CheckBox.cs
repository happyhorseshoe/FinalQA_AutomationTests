using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomatedTesting.ClassTests
{
    public class CheckBox : IDisposable
    {
        private readonly IWebDriver driver;

        public CheckBox()
        {
            driver = new ChromeDriver();
        }

        [Fact]
        public void CheckBoxTest()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");

            IWebElement checkbox1 = driver.FindElement(By.CssSelector("input[type='checkbox']:first-of-type"));
            checkbox1.Click();

            Assert.True(checkbox1.Selected);
        }

        [Fact]
        public void DropDownTest()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");

            SelectElement drop = new SelectElement(driver.FindElement(By.Id("dropdown")));
            drop.SelectByIndex(2);

            string selectedOption = drop.SelectedOption.Text;
            Assert.Equal("Option 2", selectedOption);
            
        }



        public void Dispose()
        {
            driver.Quit();
        }
    }
}



