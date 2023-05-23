using Gherkin;
using MarsProjectQA.Pages;
using MarsProjectQA.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsProjectQA.StepDefinitions
{
    [Binding]
    public class AddDescriptionStepDefinitions: CommonDriver
    {
        HomePage homePageObj;
        ProfilePage profilePageObj;
        SignInPage signInPageObj;

        public AddDescriptionStepDefinitions()
        {
            profilePageObj = new ProfilePage();
            homePageObj = new HomePage();
            signInPageObj = new SignInPage();
        }



        [When(@"I add a new description")]
        public void WhenIAddANewDescription()
        {
            profilePageObj.CreateDescription();
        }

        [Then(@"Then the new description should be added succesfully")]
        public void ThenThenTheNewDescriptionShouldBeAddedSuccesfully()
        {
            string getDescription = profilePageObj.getAddDescription();
            Assert.That(getDescription == "nothing", "Actual code and expected code do Not match");
        }
        [When(@"I updated my '([^']*)'")]
        public void WhenIUpdatedMy(string description)
        {
            profilePageObj.UpdateDescription(description);
        }
        [Then(@"Then '([^']*)' should be updated successfully")]
        public void ThenThenShouldBeUpdatedSuccessfully(string description)
        {
            string getDescription1 = profilePageObj.getUpdatedDescription();
            Assert.That(getDescription1 == description, "Actual code and expected code do Not match");
        }


    }
}
