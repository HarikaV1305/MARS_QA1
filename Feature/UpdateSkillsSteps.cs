using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class UpdateSkillsSteps

    {

       

        SkillDetails skilladd1 = new SkillDetails();

        [Given(@"seller updates Addskill as ""(.*)""")]
        public void GivenSellerUpdatesAddskillAs(string AddSkill)
        {
            skilladd1.AddSkill = AddSkill;
            
        }
        
        [Given(@"select Choose Skill Level as ""(.*)""")]
        public void GivenSelectChooseSkillLevelAs(string SkillLevel)
        {
            skilladd1.SkillLevel = SkillLevel;
        }
        
        [When(@"clicks on UpdateIcon button")]
        public void WhenClicksOnUpdateIconButton()
        {
            skilladd1.UpdateSkillDetails();
        }
        
        [Then(@"skills should be updated\.The alert message, ""(.*)"" will be displayed on the top right of the application\.")]
        public void ThenSkillsShouldBeUpdated_TheAlertMessageWillBeDisplayedOnTheTopRightOfTheApplication_(string message)
        {

            Assert.AreEqual(message, skilladd1.SkillMessage);
            Console.WriteLine("Test is passed");

        }
    }
}
