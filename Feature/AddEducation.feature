Feature: AddEducation
	Adding ,updating and deleting seller profile details.

@mytag
Scenario: 13 Test Add Education Sucessfully
Given select college as "JNTU university"
And   select country of college as "India"
And   select Title as "B.Tech"
And  select enter Degree as "Computers"
And select year as "2010"
When clicks on EduAdd action button
Then Education should be added to your profile .The alert message ,"Education has been added" will be displayed on the top right of the application.






@mytag
Scenario: 13 Test Update Education Sucessfully
Given select college as a "Illinoise university"
And   select country of college as a "United States"
And   select Title as a "M.Tech"
And  select enter Degree as a "Mataverse"
And  select year as a "2012"
When clicks on EduUpdate action button
Then Education should be added to your profile .The alert message as ,"Education as been updated" will be displayed on the top right of the application.
