Feature: AddLanguage 
As a Seller 
I want to add a Langugae to the Profile
so that
The perople seeking for specific language can look into my details.
Acceptance criteria
Seller is able to add the language

	
@mytag
Scenario: 01 Test Add language sucessfully
	Given seller enter language as "English"
	And select level as "Basic"
	When clicks on Add action button
	Then Lanuguage should be added to your profile .The alert message, "English has been added to your languages" will be displayed on the top right of the application.



	@mytag
Scenario: 02 Test Update language sucessfully
	Given seller updates language as "spanish"
	And select level as  "Fluent"
	When clicks on Update button
	Then Lanuguage should be updated.The alert message, "spanish has been updated to your languages" will be displayed on the top right of the application.

	

	@mytag
Scenario: :03 Test Add existing language unsucessful
      Given seller enter existing language as "Japanese"
	  And select language level as "Conversational"
	  When clicks on a Add action button
	  Then Language  should be pop up with the alert message,"This language is already exist in your language list." will be displayed on the top right of the application.

      @mytag
Scenario: 04 Test Updating Exisiting language unsucessful
       Given seller updates language as a "Latin"
	   And select language level as a "Basic"
	   When clicks on a Update button
	   Then Language should be pop up with thge alret message,"This language is already added to your language list." will be displayed on the top right of the application.


@mytag
Scenario: 05 Test Delete language sucessfully
	
	   When seller select to delete language "spanish"
	   Then Lanuguage should be deleted.The alert message, "spanish has been deleted from your languages" will be displayed on the top right of the application.

