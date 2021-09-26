using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class UpdateEducationSteps
    {
        EducationDetails educat2 = new EducationDetails();
       
        
        
        [Given(@"select college as a ""(.*)""")]

        public void GivenSelectCollegeAsA(string CollegeName)
        {
            educat2.CollegeName = CollegeName;
        }
        
        [Given(@"select country of college as a ""(.*)""")]
        public void GivenSelectCountryOfCollegeAsA(string CountryOfCollege)
        {
            educat2.CountryOfCollege = CountryOfCollege;
        }
        
        [Given(@"select Title as a ""(.*)""")]
        public void GivenSelectTitleAsA(string Title)
        {
            educat2.Title = Title;
        }
        
        [Given(@"select enter Degree as a ""(.*)""")]
        public void GivenSelectEnterDegreeAsA(string Degree)
        {
            educat2.Degree = Degree;
        }
        
        [Given(@"select year as a ""(.*)""")]
        public void GivenSelectYearAsA(string YearOfGraducation)
        {
            educat2.YearOfGraduation = YearOfGraducation;
        }

        [When(@"clicks on EduUpdate action button")]
        public void WhenClicksOnEduUpdateActionButton()
        {
            educat2.UpdateEducation();
        }

        
        [Then(@"Education should be added to your profile \.The alert message as ,""(.*)"" will be displayed on the top right of the application\.")]
        public void ThenEducationShouldBeAddedToYourProfile_TheAlertMessageAsWillBeDisplayedOnTheTopRightOfTheApplication_(string message)
        {
            Assert.AreEqual(message, educat2.EducationPOPupMSG);
            Console.WriteLine("Test is passed");
        }
    }
}
