using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace AutomatedTesting.PageObjectModels
{
    internal class LumaSigninPage
    {
        internal string SigninPageUrl = "https://magento.softwaretestingboard.com/customer/account/login/referer/aHR0cHM6Ly9tYWdlbnRvLnNvZnR3YXJldGVzdGluZ2JvYXJkLmNvbS8%2C/";

        internal string SigninPageTitle = "Customer Login";

        string signinIcon = ("authorization-link");
        internal By SigninIcon { get => By.ClassName(signinIcon); }


        string emailInput = "email";
        internal By EmailInput { get => By.Id(emailInput); }


        string passwordInput = "password";
        internal By PasswordInput { get => By.Id(passwordInput); }

        internal string validEmail = "roni_cost@example.com";
        internal string validPassword = "roni_cost3@example.com";


        string emailError = "email-error";
        internal By EmailError { get => By.Id(emailError); }


        string passwordError = "pass-error";
        internal By PasswordError { get => By.Id(passwordError); }
    }
}
