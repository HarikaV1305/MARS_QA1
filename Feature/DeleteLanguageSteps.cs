using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class DeleteLanguageSteps
    {
        LanguageDetails deletlang = new LanguageDetails();

        [When(@"seller select to delete language ""(.*)""")]
        public void WhenSellerSelectToDeleteLanguage(string p0)
        {
            deletlang.DeleteLang();
            
        }
        
        [Then(@"Lanuguage should be deleted\.The alert message, ""(.*)"" will be displayed on the top right of the application\.")]
        public void ThenLanuguageShouldBeDeleted_TheAlertMessageWillBeDisplayedOnTheTopRightOfTheApplication_(string message)
        {
            Assert.AreEqual(message, deletlang.LanguageMessage);
            Console.WriteLine("Test is passed");
        }
    }
}
