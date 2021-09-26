using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddExistingLanguageSteps
    {

        LanguageDetails langdet2 = new LanguageDetails();

        [Given(@"seller enter existing language as ""(.*)""")]
        public void GivenSellerEnterExistingLanguageAs(string Language)
        {
            langdet2.Language = Language;

        }

        [Given(@"select language level as ""(.*)""")]
        public void GivenSelectLanguageLevelAs(string Level)
        {

            langdet2.Level = Level;
        }
        
        [When(@"clicks on a Add action button")]
        public void WhenClicksOnAAddActionButton()
        {
            langdet2.AddLang();
        }
        
        [Then(@"Language  should be pop up with the alert message,""(.*)"" will be displayed on the top right of the application\.")]
        public void ThenLanguageShouldBePopUpWithTheAlertMessageWillBeDisplayedOnTheTopRightOfTheApplication_(string message)
        {
            Assert.AreEqual(message, langdet2.LanguageMessage);
            Console.WriteLine("Test is passed");

        }
    }
}
