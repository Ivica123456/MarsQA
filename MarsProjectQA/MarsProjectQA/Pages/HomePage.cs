using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsProjectQA.Utilities;

namespace MarsProjectQA.Pages
{
    public class HomePage : CommonDriver
    {
     public void GoToSingPage(IWebDriver driver)
        {

            //driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));


            //Lunch Trade Your Skills For A New Skill platform

            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);






        }



    }
}
