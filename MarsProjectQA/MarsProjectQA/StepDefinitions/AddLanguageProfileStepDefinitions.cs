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

        SignInPage signInPageObj;
        HomePage homePageObj;
        ProfilePage profilePageObj;
        

        public AddLanguageProfileStepDefinitions()
        {
            homePageObj = new HomePage();
            profilePageObj = new ProfilePage();
            signInPageObj = new SignInPage();
        }


        [Given(@"I launch and log into MarsQA portal successfully")]
        public void GivenILaunchAndLogIntoMarsQAPortalSuccessfully()
        {
            
            homePageObj.GoToSingPage();

            
            signInPageObj.SignInActions();



        }

        [When(@"I add a new Language")]
        public void WhenIAddANewLanguage()
        {

            
            profilePageObj.AddLanguages();
        }

        [Then(@"Then new language should be added successfully")]
        public void ThenThenNewLanguageShouldBeAddedSuccessfully()
        {
            string language = profilePageObj.newLanguage();

            Assert.That(language == "English", "Actual code and expected code do not match.");
        }
        [When(@"I edited a new language")]
        public void WhenIEditedANewLanguage()
        {

            profilePageObj.editNewLanguage();
        }
        [Then(@"Then a new language should be edited successfully")]
        public void ThenThenANewLanguageShouldBeEditedSuccessfully()
        {
            string editedLanguage = profilePageObj.editedLanguage1();
            Assert.That(editedLanguage == "Italian", "Actual code and expected code do not match.");
        }
        [When(@"I deleted a language")]
        public void WhenIDeletedALanguage()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.deletedLanguage1();


        }
        [Then(@"Then language should be deleted")]
        public void ThenThenLanguageShouldBeDeleted()
        {
            string deletedLanguage2 = profilePageObj.getdeleteLanguage();
            Assert.That(deletedLanguage2 != "Italian", "Actual code and expected code do not match.");
        }
        


    }
}
