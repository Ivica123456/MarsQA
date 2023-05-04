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

        ProfilePage profilePageObj;

         public AddSkillsProfileStepDefinitions()
         {

            profilePageObj = new ProfilePage();
         }




        [Given(@"I lunch and log into MarsQA portal successfully")]
        public void GivenILunchAndLogIntoMarsQAPortalSuccessfully()
        {
            


            //Home Page Object initalization and definition

            HomePage homePageObj = new HomePage();
            homePageObj.GoToSingPage(driver);

            //SignIn Page Object initalization and definition

            SignInPage signInPageObj = new SignInPage();
            signInPageObj.SignInActions(driver);
        }

        [When(@"I add new Skill")]
        public void WhenIAddNewSkill()
        {

            profilePageObj.AddSkill(driver);

        }

        [Then(@"Then new Skill should be added successfully")]
        public void ThenThenNewSkillShouldBeAddedSuccessfully()
        {
            string skill = profilePageObj.getSkill(driver);
            Assert.AreEqual("breathing", skill, "Actual code and expected code do not match.");

        }
        [When(@"I edited a new skill")]
        public void WhenIEditedANewSkill()
        {
            profilePageObj.editedSkills(driver);
        }
        [Then(@"Then the new skill should be edited successfully")]
        public void ThenThenTheNewSkillShouldBeEditedSuccessfully()
        {
            string newEdit = profilePageObj.newEditSkills(driver);
            Assert.AreEqual("Computer skills",newEdit,"Actual code and expected code do not match.");
        }
        [When(@"I deleted a new skill")]
        public void WhenIDeletedANewSkill()
        {
            profilePageObj.deleteNewSkills(driver);
        }
        [Then(@"Then a new skill should be deleted successfully")]
        public void ThenThenANewSkillShouldBeDeletedSuccessfully()
        {
            string deletedSkills1 = profilePageObj.lastDeleteSkill(driver);
            Assert.That(deletedSkills1 != "Computer skills", "Actual code and expected code do not match.");
        }


    }
}
