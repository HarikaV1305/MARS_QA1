using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddSkillsSteps
    {
        SkillDetails skilladd1 = new SkillDetails();

        [Given(@"seller enter Addskill as ""(.*)""")]
        public void GivenSellerEnterAddskillAs(string AddSkill)
        {
            skilladd1.AddSkill = AddSkill;

        }
        
        [Given(@"select Choose Skill Level  as ""(.*)""")]
        public void GivenSelectChooseSkillLevelAs(string SkillLevel)
        {
            skilladd1.SkillLevel = SkillLevel;
        }
        
        [When(@"clicks on AddBtn action button")]
        public void WhenClicksOnAddBtnActionButton()
        {
            skilladd1.AddskillDeatails();
        }
        
        [Then(@"Skills should be added to your profile \.The alert message, ""(.*)"" will be displayed on the top right of the application\.")]
        public void ThenSkillsShouldBeAddedToYourProfile_TheAlertMessageWillBeDisplayedOnTheTopRightOfTheApplication_(string message)
        {
            Assert.AreEqual(message, skilladd1.SkillMessage);
            Console.WriteLine("Test is passed");
        }
    }
}
