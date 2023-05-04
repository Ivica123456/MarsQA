
using MarsProjectQA.Pages;
using MarsProjectQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace POM.Tests
{
    [TestFixture]
    class profilePageTests : CommonDriver
    {
        ProfilePage profilePageObj = new ProfilePage();

        [Test , Order(1)]
        public void loginActions()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            driver.Manage().Window.Maximize();
            

            HomePage homePageObj = new HomePage();
            homePageObj.GoToSingPage(driver);

            SignInPage signInPageObj = new SignInPage();
            signInPageObj.SignInActions(driver);

            //driver.Close();
        }
        [Test, Order(2)]
        public void CreateProfilePage()
        {

            profilePageObj.CreateProfile(driver);

        }

        [Test, Order(3)]
        public void EditProfilePage()
        {


            profilePageObj.EditCertification(driver);
            profilePageObj.editLanguage(driver);
            profilePageObj.editedSkills(driver);


        }
        [Test, Order(4)]
        public void DeleteProfilePage()
        {

            profilePageObj.deleteCertification(driver);
            profilePageObj.deletedLanguage1(driver);
            profilePageObj.deleteNewSkills(driver);
        }
    }
}


