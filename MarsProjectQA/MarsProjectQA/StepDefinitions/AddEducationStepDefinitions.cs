using MarsProjectQA.Pages;
using MarsProjectQA.Pages.model;
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
            homePageObj.GoToSingPage();


            signInPageObj.SignInActions();
        }

        [When(@"When I add my education including '([^']*)', '([^']*)', '([^']*)', '([^']*)','([^']*)'")]
        public void WhenWhenIAddMyEducationIncluding(string Country, string University, string Title, string Degree, string Graduation)
        {
            profilePageObj.AddEducation(Country, University, Title, Degree, Graduation);
        }

        [Then(@"Then I am able to see my education details including '([^']*)', '([^']*)', '([^']*)', '([^']*)','([^']*)'")]
        public void ThenThenIAmAbleToSeeMyEducationDetailsIncluding(string country, string University, string Title, string Degree, string Graduation)
        {
            EducationInfo educationInfo = profilePageObj.getEducationCountryName(country);
            Assert.AreEqual(country, educationInfo.getCountryName());
            EducationInfo educationInfo1 = profilePageObj.getEducationCountryName(University);
            Assert.AreEqual(University , educationInfo.getUniversityName());
            EducationInfo educationInfo2 = profilePageObj.getEducationCountryName(Title);
            Assert.AreEqual(Title, educationInfo.getTitleName());
            EducationInfo educationInfo3 = profilePageObj.getEducationCountryName(Degree);
            Assert.AreEqual(Degree, educationInfo.getDegreeName());
            EducationInfo educationInfo4 = profilePageObj.getEducationCountryName(Graduation);
            Assert.AreEqual(Graduation, educationInfo.getGradutaiongName());


        }
    }
}
