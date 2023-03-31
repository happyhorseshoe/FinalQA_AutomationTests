using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using FluentAssertions;
using FluentAssertions.Execution;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using AutomatedTesting.PageObjectModels;

namespace AutomatedTesting.ClassTests
{


    public class NewTabShould : IDisposable
    {
        IWebDriver _driver;
        NewTab240 _newTab240;

        public NewTabShould()
        {
            IWebDriver driver = new ChromeDriver();
            _driver = driver;

            NewTab240 newtab240 = new NewTab240();
            _newTab240 = newtab240;

        }



        [Fact]
        public void NewTabInFaceBookTest()
        {


            _driver.Navigate().GoToUrl(_newTab240.BaseTabUrl);



            //act

            var fbLink = _driver.FindElement(_newTab240.FacebookIdLink);
            fbLink.Click();


            _driver.SwitchTo().Window(_driver.WindowHandles.Last());



            //assert
            using (new AssertionScope())
            {
                _driver.WindowHandles.Should().HaveCount(2);
                
            }

            //cleanup

        }
        public void Dispose()
        {
            _driver.Quit();
        }
    }

}