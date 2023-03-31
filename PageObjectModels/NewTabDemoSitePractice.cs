using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomatedTesting.PageObjectModels
{
    internal class NewTabDemoSitePractice
    {
        internal string DemoUrl = "https://www.lambdatest.com/selenium-playground/select-dropdown-demo";

        string dropDownDay = "select-demo";
        internal By DropDownMenu { get => By.Id(dropDownDay); }

        string fridayChoice = ".selected-value.text-size-14";
        internal By Friday { get => By.CssSelector(fridayChoice); }
    }
}
