using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomatedTesting.PageObjectModels
{
    internal class LumaLandingPage
    {
        internal string HomeUrl = "https://magento.softwaretestingboard.com/";
        internal string HomeTitle = "Home Page";
        internal string WhatsNewUrl = "https://magento.softwaretestingboard.com/what-is-new.html";

        string trainingXpath = "//span[contains(text(),'Training')]";
        internal By HoveringOverTraining { get => By.XPath(trainingXpath); }

        string downloadLink = "ui-id-7";
        internal By DownloadLink { get => By.Id(downloadLink); }
    }
}
//*[@id="ui-id-7"]