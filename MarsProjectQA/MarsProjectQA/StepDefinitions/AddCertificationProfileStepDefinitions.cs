using MarsProjectQA.Pages;
using MarsProjectQA.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsProjectQA.StepDefinitions
{
    [Binding]
    public class AddCertificationProfileStepDefinitions : CommonDriver
    {

        ProfilePage profilePageObj;

        public AddCertificationProfileStepDefinitions()
        {
            profilePageObj = new ProfilePage();
        }




        [Given(@"I lanch and log into MarsQA portal successfully")]
        public void GivenILanchAndLogIntoMarsQAPortalSuccessfully()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.GoToSingPage(driver);

            SignInPage signInPageObj = new SignInPage();
            signInPageObj.SignInActions(driver);
        }

        [When(@"I add a new certification")]
        public void WhenIAddANewCertification()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.CreateProfile(driver);
        }

        [Then(@"Then the new certification should be added succesfully")]
        public void ThenThenTheNewCertificationShouldBeAddedSuccesfully()
        {
            string addcertification = profilePageObj.getCertification(driver);
            Assert.That(addcertification == "pdf" , "Actual code and expected code do not match.");
        }
       
        
        // Edit 
        
        [When(@"I edited a new certification")]
        public void WhenIEditedANewCertification()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.EditCertification(driver);
        }
       
        
        
        [Then(@"Then a new certification should be edited")]
        public void ThenThenANewCertificationShouldBeEdited()
        {
            string editedCertification = profilePageObj.updatedCertification(driver);
            Assert.That(editedCertification == "NetRiders2012", "Actual code and expected code do not match.");
        }
        [When(@"I deleted certification")]
        public void WhenIDeletedCertification()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.deleteCertification(driver);
        }
        [Then(@"Then certification should be deleted")]
        public void ThenThenCertificationShouldBeDeleted()
        {
            string lastDelete = profilePageObj.DeletedCertification(driver);
            Assert.That(lastDelete != "NetRiders 2012" , "Actual code and expected code do not match.");
        }


    }
}
