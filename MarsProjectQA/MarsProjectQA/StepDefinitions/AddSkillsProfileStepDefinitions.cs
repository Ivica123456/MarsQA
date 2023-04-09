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
        ProfilePage profilePageObj = new ProfilePage();

        [Given(@"I lunch and log into MarsQA portal successfully")]
        public void GivenILunchAndLogIntoMarsQAPortalSuccessfully()
        {
            IWebDriver driver = new ChromeDriver();


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
            
            profilePageObj.CreateProfile(driver);
        }

        [Then(@"Then new Skill should be added successfully")]
        public void ThenThenNewSkillShouldBeAddedSuccessfully()
        {
            string skill = profilePageObj.getSkill(driver);
            Assert.That(skill == "Deep breathing" , "Actual code and expected code do not match.");

        }
    }
}
