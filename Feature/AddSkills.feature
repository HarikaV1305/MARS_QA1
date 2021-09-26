Feature: AddSkills
	Simple calculator for adding two numbers
Scenario: 01 Test Add skills sucessfully
	Given seller enter Addskill as "C#coding"
	And select Choose Skill Level  as "Expert"
	When clicks on AddBtn action button
	Then Skills should be added to your profile .The alert message, "C#coding has been added to your skills" will be displayed on the top right of the application.



	@mytag
Scenario: 02 Test Update skills sucessfully
	Given seller updates Addskill as "programming in restsharp"
	And select Choose Skill Level as "Intermediate"
	When clicks on UpdateIcon button
	Then skills should be updated.The alert message, "programming in restsharp has been updated to your skills" will be displayed on the top right of the application.


		
@mytag
Scenario: 03 Test Delete skills sucessfully	
	When seller select to delete skills "programming in restsharp"
	Then skills should be deleted.The alert message, "programming in restsharp has been deleted" will be displayed on the top right of the application.
