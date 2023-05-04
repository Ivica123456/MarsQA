using MarsProjectQA.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsProjectQA.Utilities
{
    [Binding]
    public class CommonDriver
    {

        public static IWebDriver driver;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            driver = new ChromeDriver();
           
            
           
            
        }

        //[AfterTestRun]
        //public static void AfterTestRun()
        //{
        //    driver.Quit();
        //}



    }
}
