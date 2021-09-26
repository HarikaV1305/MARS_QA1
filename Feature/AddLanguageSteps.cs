using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddLanguageSteps

    {
        LanguageDetails langDeta1 = new LanguageDetails();

        [Given(@"seller enter language as ""(.*)""")]
        public void GivenSellerEnterLanguageAs(string Language)
        {
            langDeta1.Language = Language;
          
        }
        
        [Given(@"select level as ""(.*)""")]
        public void GivenSelectLevelAs(string Level)
        {
            
            langDeta1.Level = Level;
           
        }

        [When(@"clicks on Add action button")]
        public void WhenClicksOnAddActionButton()
        {
            langDeta1.AddLang();
        }
            [Then(@"Lanuguage should be added to your profile \.The alert message, ""(.*)"" will be displayed on the top right of the application\.")]
        public void ThenLanuguageShouldBeAddedToYourProfile_TheAlertMessageWillBeDisplayedOnTheTopRightOfTheApplication_(string message)
        {

            Assert.AreEqual(message, langDeta1.LanguageMessage);
            Console.WriteLine("Test is passed");


        }
    }
}
