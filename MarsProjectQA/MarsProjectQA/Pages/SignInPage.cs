using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectQA.Pages
{
    public class SignInPage
    {
        public void SignInActions(IWebDriver driver)
        {
            IWebElement signIN = driver.FindElement(By.XPath("//a[@class='item']"));
            signIN.Click();

            // Enter valid username in TextBox

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
