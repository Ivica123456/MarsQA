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
        //private WebDriver driver;
        WebDriverWait wait1;

        public HomePage()
        {
            //driver = new ChromeDriver();
            wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }
        
        public void GoToSingPage()
       
        {


                //Open chrome browser
                driver.Manage().Window.Maximize();
                //Launch Mars portal
                driver.Navigate().GoToUrl("http://localhost:5000");






        }



    }
}
