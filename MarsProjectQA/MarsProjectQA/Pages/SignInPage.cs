using MarsProjectQA.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectQA.Pages
{
    public class SignInPage : CommonDriver
    {

        //WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

        public void SignInActions(IWebDriver driver)
        {
            IWebElement signIN = driver.FindElement(By.XPath("//a[@class='item']"));
            signIN.Click();

            // Enter valid username in TextBox

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//input[@placeholder='Email address']")));
            IWebElement userName = driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
            
            userName.SendKeys("ivica.cuncic@gmail.com");
            Thread.Sleep(2000);
            // Enter valid password in TextBox

            IWebElement password = driver.FindElement(By.XPath("//input[@placeholder='Password']"));
            password.SendKeys("mars123");
            Thread.Sleep(2000);
            // Click on Login

            IWebElement login = driver.FindElement(By.XPath("//button[@class='fluid ui teal button']"));
            login.Click();
            Thread.Sleep(4000);




        }



    }
}
