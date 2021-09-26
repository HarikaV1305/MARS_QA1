using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddEducationSteps
    {
        EducationDetails Edudet1 = new EducationDetails();

          [Given(@"select college as ""(.*)""")]
        public void GivenSelectCollegeAs(string CollegeName)
        {
            Edudet1.CollegeName = CollegeName;

        }
        
        [Given(@"select country of college as ""(.*)""")]
        public void GivenSelectCountryOfCollegeAs(string CountryOfCollege)
        {
            Edudet1.CountryOfCollege = CountryOfCollege;
        }
        
        [Given(@"select Title as ""(.*)""")]
        public void GivenSelectTitleAs(string Title)
        {
            Edudet1.Title = Title;
        }
        
        [Given(@"select enter Degree as ""(.*)""")]
        public void GivenSelectEnterDegreeAs(string Degree)
        {
            Edudet1.Degree = Degree;
        }

        [Given(@"select year as ""(.*)""")]
        public void GivenSelectYearAs(string  YearOfGraducation)
        {
            Edudet1.YearOfGraduation = YearOfGraducation;
        }

        [When(@"clicks on EduAdd action button")]
        public void WhenClicksOnEduAddActionButton()
        {
            Edudet1.AddEducation();
        }
        
        [Then(@"Education should be added to your profile \.The alert message ,""(.*)"" will be displayed on the top right of the application\.")]
        public void ThenEducationShouldBeAddedToYourProfile_TheAlertMessageWillBeDisplayedOnTheTopRightOfTheApplication_(string message)
        {
            Assert.AreEqual(message, Edudet1.EducationPOPupMSG);
            Console.WriteLine("Test is passed");
        }
    }
}
