using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomatedTesting.PageObjectModels
{
    internal class NewTab240
    {

        internal string BaseTabUrl = "http://240adams.com/index.php/rentals/";
        internal string AdamsPageTitle = "240 Adams LLC";

        string facebookIdLink = "sfsiid_facebook";
        internal By FacebookIdLink { get => By.Id(facebookIdLink); }


    }
}

