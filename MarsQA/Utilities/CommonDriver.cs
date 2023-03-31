using MarsQA.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Utilities
{
    public class CommonDriver
    {

        public IWebDriver driver;
        [SetUp]
        public void SignInSteps()
        {
            driver = new ChromeDriver();

            //Home Page Object initalization and definition

            HomePage homePageObj = new HomePage();
            homePageObj.GoToSignPage(driver);


            //SignIn Page Object initalization and definition

            SignIn signInObj = new SignIn();
            signInObj.SignInActions(driver);
        }
    }
}
