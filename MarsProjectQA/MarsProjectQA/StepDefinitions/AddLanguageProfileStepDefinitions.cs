using MarsProjectQA.Utilities;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using MarsProjectQA.Pages;
using NUnit.Framework;

namespace MarsProjectQA.StepDefinitions
{
    [Binding]
    public class AddLanguageProfileStepDefinitions : CommonDriver
    {
        ProfilePage profilePageObj = new ProfilePage();


        [Given(@"I launch and log into MarsQA portal successfully")]
        public void GivenILaunchAndLogIntoMarsQAPortalSuccessfully()
        {
            
            IWebDriver driver = new ChromeDriver();

            HomePage homePageObj = new HomePage();
            homePageObj.GoToSingPage(driver);
            SignInPage signInPageObj = new SignInPage();
            signInPageObj.SignInActions(driver);
        }

        [When(@"I add a new Language")]
        public void WhenIAddANewLanguage()
        {
            
            profilePageObj.CreateProfile(driver);
        }

        [Then(@"Then new language should be added successfully")]
        public void ThenThenNewLanguageShouldBeAddedSuccessfully()
        {
            string language = profilePageObj.newLanguage(driver);

            Assert.That(language == "English", "Actual code and expected code do not match.");
        }
    }
}
