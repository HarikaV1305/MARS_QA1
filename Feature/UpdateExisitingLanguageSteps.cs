using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class UpdateExisitingLanguageSteps
    {
        LanguageDetails langupdte1 = new LanguageDetails();

       [Given(@"seller updates language as a ""(.*)""")]
       
        public void GivenSellerUpdatesLanguageAsA(string Language)
        {
            langupdte1.Language = Language;
        }
        
        [Given(@"select language level as a ""(.*)""")]
        public void GivenSelectLanguageLevelAsA(string Level)
        {
            langupdte1.Level = Level;
        }
        
        [When(@"clicks on a Update button")]
        public void WhenClicksOnAUpdateButton()
        {
            langupdte1.UpdateLang();
        }
        
        [Then(@"Language should be pop up with thge alret message,""(.*)"" will be displayed on the top right of the application\.")]
        public void ThenLanguageShouldBePopUpWithThgeAlretMessageWillBeDisplayedOnTheTopRightOfTheApplication_(string message)
        {
            Assert.AreEqual(message, langupdte1.LanguageMessage);
            Console.WriteLine("Test is passed");
        }
    }
}
