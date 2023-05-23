using MarsProjectQA.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using MarsProjectQA.Utilities;
using NUnit.Framework;

namespace MarsProjectQA.StepDefinitions
{
    [Binding]
    public class AddSkillsProfileStepDefinitions : CommonDriver
    {
        HomePage homePageObj;
        ProfilePage profilePageObj;
        SignInPage signInPageObj;

         public AddSkillsProfileStepDefinitions()
         {
            homePageObj = new HomePage();
            profilePageObj = new ProfilePage();
            signInPageObj = new SignInPage();
        }




        [Given(@"I lunch and log into MarsQA portal successfully")]
        public void GivenILunchAndLogIntoMarsQAPortalSuccessfully()
        {
            


            //Home Page Object initalization and definition

            
            homePageObj.GoToSingPage(driver);

            //SignIn Page Object initalization and definition

            
            signInPageObj.SignInActions(driver);
        }

        [When(@"I add new Skill")]
        public void WhenIAddNewSkill()
        {

            profilePageObj.getSkill();

        }

        [Then(@"Then new Skill should be added successfully")]
        public void ThenThenNewSkillShouldBeAddedSuccessfully()
        {
            string skill = profilePageObj.getSkill();
            Assert.That(skill == "breathing", "Actual code and expected code do not match.");

        }
        [When(@"I edited a new skill")]
        public void WhenIEditedANewSkill()
        {
            profilePageObj.editedSkills();
        }
        [Then(@"Then the new skill should be edited successfully")]
        public void ThenThenTheNewSkillShouldBeEditedSuccessfully()
        {
            string newEdit = profilePageObj.newEditSkills();
            Assert.That(newEdit == "Computer skills", "Actual code and expected code do not match.");
        }
        [When(@"I deleted a new skill")]
        public void WhenIDeletedANewSkill()
        {
            profilePageObj.deleteNewSkills();
        }
        [Then(@"Then a new skill should be deleted successfully")]
        public void ThenThenANewSkillShouldBeDeletedSuccessfully()
        {
            string deletedSkills1 = profilePageObj.lastDeleteSkill();
            Assert.That(deletedSkills1 != "Computer skills", "Actual code and expected code do not match.");
        }


    }
}
