using MarsProjectQA.Pages;
using MarsProjectQA.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsProjectQA.StepDefinitions
{
    [Binding]
    public class AddEducationStepDefinitions: CommonDriver
    {
        HomePage homePageObj;
        ProfilePage profilePageObj;
        SignInPage signInPageObj;

        public AddEducationStepDefinitions()
        {
            profilePageObj = new ProfilePage();
            homePageObj = new HomePage();
            signInPageObj = new SignInPage();
        }
        [Given(@"I lanch and log into MarsQA portal successfully")]
        public void GivenILanchAndLogIntoMarsQAPortalSuccessfully()
        {
            homePageObj.GoToSingPage(driver);


            signInPageObj.SignInActions(driver);
        }

        [When(@"When I add my education including '([^']*)', '([^']*)', '([^']*)', '([^']*)','([^']*)'")]
        public void WhenWhenIAddMyEducationIncluding(string Country, string University, string Title, string Degree, string Graduation)
        {
            profilePageObj.AddEducation(Country, University, Title, Degree, Graduation);
        }

        [Then(@"Then I am able to see my education details including '([^']*)', '([^']*)', '([^']*)', '([^']*)','([^']*)'")]
        public void ThenThenIAmAbleToSeeMyEducationDetailsIncluding(string Country, string University, string Title, string Degree, string Graduation)
        {
            string CountryCollegeSelectUpdate = profilePageObj.GetUpdatedCountryCollegeSelect();
            Assert.That(CountryCollegeSelectUpdate == Country, "Actual code and expected code do not match.");
            string UniversityNameUpdate = profilePageObj.GetUpdatedUniversityName();
            Assert.That(UniversityNameUpdate == University, "Actual code and expected code do not match.");
            
            

            string EducationTitleUpdate = profilePageObj.GetEducationTitle();
            Assert.That(EducationTitleUpdate == Title, "Actual code and expected code do not match.");
            string EducationDegreeUpdate = profilePageObj.GetEducationDegree();
            Assert.That(EducationDegreeUpdate == Degree, "Actual code and expected code do not match.");
            string EducationSelectedYearUpdate = profilePageObj.GetEducationSelectedYear();
            Assert.That(EducationSelectedYearUpdate == Graduation, "Actual code and expected code do not match.");
        }
    }
}
