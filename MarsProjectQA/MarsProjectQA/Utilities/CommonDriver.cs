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

        [AfterTestRun]
        public static void AfterTestRun()
        {
            //IWebElement delete = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[2]"));
            //delete.Click();

            //driver.Dispose();
        }



    }
}
