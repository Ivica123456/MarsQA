using MarsProjectQA.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
        

        WebDriverWait wait1;
        IWebElement signInButton => driver.FindElement(By.XPath("//a[contains(@class,\"item\")]"));
        IWebElement emailTextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        IWebElement passwordTextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        IWebElement rememberMeCheckbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[3]/div/input"));
        IWebElement loginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));




        public SignInPage()
        {
            
            wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }       
        
        
        
        public void SignInActions()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//a[contains(@class,\"item\")]", 10);
            signInButton.Click();

            // Enter valid username in TextBox

            Wait.WaitToBeVisible(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[1]/input", 5);
            emailTextbox.SendKeys("ivica.cuncic@gmail.com");

            // Enter valid password in TextBox
            passwordTextbox.SendKeys("mars123");
            
            //Identify remember me checkbox and click
            rememberMeCheckbox.Click();

            // Click on Login
            loginButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a", 10);


        }
        

    }



}

