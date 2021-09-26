using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class DeleteSkillsSteps
    {
        SkillDetails DeletSkil = new SkillDetails();
        [When(@"seller select to delete skills ""(.*)""")]
        public void WhenSellerSelectToDeleteSkills(string p0)
        {
            DeletSkil.DeleteSkill();
        }
        
        [Then(@"skills should be deleted\.The alert message, ""(.*)"" will be displayed on the top right of the application\.")]
        public void ThenSkillsShouldBeDeleted_TheAlertMessageWillBeDisplayedOnTheTopRightOfTheApplication_(string message)
        {
            Assert.AreEqual(message,DeletSkil.SkillMessage);
            Console.WriteLine("Test is passed");
        }
    }
}
