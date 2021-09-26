using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class UpdateLanguageSteps
        
    {
        LanguageDetails updatelang1 = new LanguageDetails();

        [Given(@"seller updates language as ""(.*)""")]
        public void GivenSellerUpdatesLanguageAs(string Language)
        {
           updatelang1.Language = Language;
        }
        
        [Given(@"select level as  ""(.*)""")]
        public void GivenSelectLevelAs(string Level)
        {
            updatelang1.Level = Level;
        }
        
        [When(@"clicks on Update button")]
        public void WhenClicksOnUpdateButton()
        {
            updatelang1.UpdateLang();
        }
        
        [Then(@"Lanuguage should be updated\.The alert message, ""(.*)"" will be displayed on the top right of the application\.")]
        public void ThenLanuguageShouldBeUpdated_TheAlertMessageWillBeDisplayedOnTheTopRightOfTheApplication_(string message)
        {
            Assert.AreEqual(message, updatelang1.LanguageMessage);
            Console.WriteLine("Test is passed");
        }
    }
}
