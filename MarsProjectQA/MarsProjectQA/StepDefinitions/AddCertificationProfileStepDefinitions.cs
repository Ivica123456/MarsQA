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
            // Replace function call of CreateProfile with AddNewCertificate
             profilePageObj.AddCertificate(driver);
            //profilePageObj.CreateProfile(driver);
        }

        [Then(@"Then the new certification should be added succesfully")]
        public void ThenThenTheNewCertificationShouldBeAddedSuccesfully()
        {
            string addcertification = profilePageObj.getCertification(driver);
            //Assert.That(addcertification == "pdf" , "Actual code and expected code do not match.");
            Assert.AreEqual("NetRiders Challenge 2011", addcertification, "Actual and expected result are not equal.");
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
            //Assert.That(editedCertification == "NetRiders  2012", "Actual code and expected code do not match.");
            Assert.AreEqual("NetRiders 2012", editedCertification, "Actual and expected result are not equal.");
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
            //Remove because it already declared 
            //ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.Addlanguage(driver);
        }

        [Then(@"Then new language should be added successfully")]
        public void ThenThenNewLanguageShouldBeAddedSuccessfully()
        {
            string language = profilePageObj.newLanguage(driver);

            Assert.AreEqual("English", language, "Actual and expected result are not equal.");
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
            Assert.AreEqual("Italian", editedLanguage, "Actual and expected result are not equal.");
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
            Assert.AreEqual("Computer skills", newEdit, "Actual code and expected code do not match.");
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
