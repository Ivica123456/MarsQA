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



        ProfilePage profilePageObj;
        

        public AddLanguageProfileStepDefinitions()
        {
            
            profilePageObj = new ProfilePage();
        }


        [Given(@"I launch and log into MarsQA portal successfully")]
        public void GivenILaunchAndLogIntoMarsQAPortalSuccessfully()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.GoToSingPage(driver);

            SignInPage signInPageObj = new SignInPage();
            signInPageObj.SignInActions(driver);



        }

        [When(@"I add a new Language")]
        public void WhenIAddANewLanguage()
        {

            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.CreateProfile(driver);
        }

        [Then(@"Then new language should be added successfully")]
        public void ThenThenNewLanguageShouldBeAddedSuccessfully()
        {
            string language = profilePageObj.newLanguage(driver);

            Assert.That(language == "English", "Actual code and expected code do not match.");
        }
        [When(@"I edited a new language")]
        public void WhenIEditedANewLanguage()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.editLanguage(driver);
        }
        [Then(@"Then a new language should be edited successfully")]
        public void ThenThenANewLanguageShouldBeEditedSuccessfully()
        {
            string editedLanguage = profilePageObj.editedLanguage1(driver);
            Assert.That(editedLanguage == "Italian", "Actual code and expected code do not match.");
        }
        [When(@"I deleted a language")]
        public void WhenIDeletedALanguage()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.deletedLanguage1(driver);


        }
        [Then(@"Then language should be deleted")]
        public void ThenThenLanguageShouldBeDeleted()
        {
            string deletedLanguage2 = profilePageObj.getdeleteLanguage(driver);
            Assert.That(deletedLanguage2 != "Italian", "Actual code and expected code do not match.");
        }

    }
}
