using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Tests
{
    [TestFixture]
    public class Description_Tests : CommonDriver
    {
        //IWebDriver driver;

        


        //[SetUp]
        //public void SignInSteps()
        //{
        //    driver = new ChromeDriver();

        //    //Home Page Object initalization and definition

        //    HomePage homePageObj = new HomePage();
        //    homePageObj.GoToSignPage(driver);


        //    //SignIn Page Object initalization and definition

        //    SignIn signInObj = new SignIn();
        //    signInObj.SignInActions(driver);
        //}
        
        [Test, Order(1)]
        public void CreateDescriprion() 
        {
            //ProfilePage Page Object initalization and definition

            

            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.CreateDescription(driver);





        }
        [Test, Order(2)]
        public void EditDescription()
        {
            //Edit ProfilePage Page Object initalization and definition

            ProfilePage EditPageObj = new ProfilePage();
            EditPageObj.UpdateDescription(driver);

        }
        [Test , Order(3)]
        public void DeleteDescription()
        {
            //Delete ProfilePage Page Object initalization and definition


            ProfilePage DeletePageObj = new ProfilePage();
            DeletePageObj.deleteCertification(driver);


        }
    }
}
