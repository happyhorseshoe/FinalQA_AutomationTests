using AutomatedTesting.PageObjectModels;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit.Abstractions;
using System;
using Xunit;
using OpenQA.Selenium.Support.UI;
using FluentAssertions;
using FluentAssertions.Execution;
using OpenQA.Selenium.Interactions;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Numerics;
using System.Security.Claims;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using SeleniumExtras.WaitHelpers;

namespace AutomatedTesting.ClassTests
{
    public class AutoTestingUI : IDisposable
    {
        readonly ITestOutputHelper output;
        IWebDriver _driver;
        WebDriverWait wait;
        CalendarMonth _calendarMonth;
        EbayHome _ebayHome;
        LumaLandingPage _lumaLandingPage;
        LumaSigninPage _lumaSigninPage;
        NewTabDemoSitePractice _newTabDemoSitePractice;
        UpLoadImage _upLoadImage;

        public AutoTestingUI(ITestOutputHelper output)
        {
            this.output = output;
            _driver = new ChromeDriver();

            CalendarMonth calendarMonth = new CalendarMonth();
            _calendarMonth = calendarMonth;

            EbayHome ebayHome = new EbayHome();
            _ebayHome = ebayHome;

            LumaLandingPage lumaLandingPage = new LumaLandingPage();
            _lumaLandingPage = lumaLandingPage;

            LumaSigninPage lumaSigninPage = new LumaSigninPage();
            _lumaSigninPage = lumaSigninPage;

            NewTabDemoSitePractice newTabDemoSitePractice = new NewTabDemoSitePractice();
            _newTabDemoSitePractice = newTabDemoSitePractice;

            UpLoadImage upLoadImage = new UpLoadImage();
            _upLoadImage = upLoadImage;
        }

        [Fact]
        public void CalendarMonthSelectorTest()
        {

            _driver.Navigate().GoToUrl(_calendarMonth.CalendarUrl);
            _driver.FindElement(_calendarMonth.CalendarField).Click();


            List<IWebElement> tableContent = new List<IWebElement>(_driver.FindElements(_calendarMonth.CalendarField));

            tableContent.Should().HaveCount(1);
        }

        [Fact]
        public void HoverOverEbayTest()
        {

            _driver.Navigate().GoToUrl(_ebayHome.EbayUrl);

            Actions action = new Actions(_driver);
            WebElement element = (WebElement)_driver.FindElement(_ebayHome.LinkTextCollectible);

            action.MoveToElement(element).Build().Perform();

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            //wait.Until{ ExpectedConditions.visible}

            WebElement element2 = (WebElement)_driver.FindElement(_ebayHome.LinkTextArt);
            action.MoveToElement(element2);
            action.MoveToElement(element2).Build().Perform();

            //test runs but figure out assert
            _driver.Title.Should().Be(_ebayHome.EbayTitle);

        }

        [Fact]
        public void HoverOverLumaTest()
        {

            _driver.Navigate().GoToUrl(_lumaLandingPage.HomeUrl);

            Actions action = new Actions(_driver);
            WebElement elementNew = (WebElement)_driver.FindElement(_lumaLandingPage.HoveringOverTraining);
            action.MoveToElement(elementNew).Build().Perform();
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));


            _driver.FindElement(_lumaLandingPage.DownloadLink).Displayed.Should().BeTrue();
        }

        [Fact]
        public void LumaHomePageTest()
        {

            _driver.Navigate().GoToUrl(_lumaLandingPage.HomeUrl);

            _driver.Title.Should().Be(_lumaLandingPage.HomeTitle);

        }

        [Fact]
        public void GoingBackToLumaHomePageTest()
        {


            _driver.Navigate().GoToUrl(_lumaLandingPage.HomeUrl);
            _driver.Navigate().GoToUrl(_lumaLandingPage.WhatsNewUrl);
            _driver.Navigate().Back();

            using (new AssertionScope())
            {
                _driver.Title.Should().Be(_lumaLandingPage.HomeTitle);
                _driver.Url.Should().Be(_lumaLandingPage.HomeUrl);
            }

        }

        [Fact]
        public void NavigatingToLumaSigninPageTest()
        {
            _driver.Navigate().GoToUrl(_lumaLandingPage.HomeUrl);

            IWebElement loginLink = _driver.FindElement(_lumaSigninPage.SigninIcon);
            loginLink.Click();

            _driver.Title.Should().Be(_lumaSigninPage.SigninPageTitle);
        }

        [Fact]
        public void NewTabTest()
        { 
            string dayOfTheWeek = "Friday";
            _driver.Navigate().GoToUrl(_newTabDemoSitePractice.DemoUrl);

            SelectElement dropDown = new SelectElement(_driver.FindElement(_newTabDemoSitePractice.DropDownMenu));
            dropDown.SelectByValue(dayOfTheWeek);
            string actualText = _driver.FindElement(_newTabDemoSitePractice.Friday).Text;
               
           
            actualText.Should().Contain(dayOfTheWeek);  

        }

        [Fact]
        public void FileUploaderTest()
        {
            _driver.Navigate().GoToUrl(_upLoadImage.FileUploadUrl);

            _driver.FindElement(_upLoadImage.ChooseFileImage).SendKeys(@"C:\Users\emorr\OneDrive\Desktop\New\TestProject1\pantaloons.png");
            _driver.FindElement(_upLoadImage.FileUploader).Click();
            
            _driver.FindElement(_upLoadImage.FileUploader).Displayed.Should().BeTrue();
        }


        [Fact]
        public void LoginWithBlankUserName()
        {
          
        _driver.Navigate().GoToUrl(_lumaSigninPage.SigninPageUrl);
         //_lumaSigninPage.EmailInput();
        
        }






        public void Dispose()
        {
            _driver.Quit();
        }



    }
}















