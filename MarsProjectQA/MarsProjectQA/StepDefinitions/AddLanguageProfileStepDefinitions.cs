using System;
using TechTalk.SpecFlow;

namespace MarsProjectQA.StepDefinitions
{
    [Binding]
    public class AddLanguageProfileStepDefinitions
    {
        [Given(@"I launch and log into MarsQA portal successfully")]
        public void GivenILaunchAndLogIntoMarsQAPortalSuccessfully()
        {
            
        }

        [When(@"I add a new Language")]
        public void WhenIAddANewLanguage()
        {
            throw new PendingStepException();
        }

        [Then(@"Then new language should be added successfully")]
        public void ThenThenNewLanguageShouldBeAddedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
