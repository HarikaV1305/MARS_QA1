Feature: Add seller profile details
As a Seller 
I want to add profile details to the Profile
so that
The people seeking for some skills can look into my details.
Acceptance criteria
Seller is able to add the profile details


#DESCRIPTION
#------------------------
#   @mytag
#   Scenario: 01 Test Description of seller sucessfully
#   Given  seller writes text in description 
#   When  click on save action button
#   Then Description should be added to your profile.The alret message ,"Description has been saved successfully" will be displayed on the top right of the application.

#    @mytag
#    Scenario: :02 Test Description maxlenght of characters sucessfully
#    Given seller enters more than six hundred Characters 
#    Then cursor should be Disable.

#LANGUAGE
#-------------------------
#
#     Scenario:03 Test blank language unsucessfully
#     Given  seller leaves language as a blank field 
#     And    select level as a "Basic"
#     When   clicks on a Add action button
#     Then   language should not be able to add to your profile..The alret message ,".The alret message ,"Please enter language and level" will be displayed on the top right of the application." will be displayed on the top right of the application.
#

       
#      Scenario: 04 Test Language  blank field unsucessful
#      Given  seller leaves langugae as a blankfield
#      And    blank Language select
#      When   clicks add action button 
#      Then   Add language should throw alert message as,"Please enter language and level"will be displayed on the top right of the application.
#


#      Scenario: 05 Test Seller is adding more than four languages 
#      Then Add New action button should be  dissapeared as user cannot add more than four languages


#SKILLS
#----------------------------

 
#      Scenario: :06 Test AddSkill as a blankfield unsucessful
#      Given seller leaves AddSkill as a blankfield
#      And blank ChooseSkillLevel as a blankfield
#      when clicks on Add action button
#      Then Add Skill should throw an alert message as," Please enter skill and experience level" will be displayed on the top right of the application.
#     
#      Scenario: 07 Test ChooseSkillLevel as a blank field unsucessfull
#      Given seller enter Addskill as a "Latin"
#      And   blank ChooseSkillLevel as a blankfield 
#      When clicks  on Add action button
#      Then Add Skill should throw an alert message as," Please enter skill and experience level" will be displayed on the top right of the application.
#       
#       
#        Scenario: 08 Test Add Exisiting Skill unsucessfull
#        Given seller enter Addskill as a "Programming in restsharp"
#        And  select   SkillLevel as   "Intermediate"
#        When clicks on  Add action button
#        Then Add skill  should throw an alert message as,"This skill is already exist in your skill list." will be displayed on the top right of the application.
#

#        Scenario: 09 Test Update Exisiting Skill unsucesssfull
#         Given seller Updates Addskill as a "Csharp coding"
#         And select Skill level as a "Intermediate"
#         When clicks on Update action button
#         Then  Update skill should throw an  alert message as,"This skill is already added to your skill list." will be displayed on the top right of the application.
#
#

# EDUCATION:
#-----------------------------------

#         @ignore
#          Scenario: 10 Test Add exisisting education details unsucessfull
#          Given select college as "JNTU university"
#          And   select country of college as "India"
#          And   select Title as "B.Tech"
#          And  select enter Degree as "Computers"
#          And select year as "2010"
#          When clicks on Add action button
##         Then Education should be added to your profile .The alert message ,"This information is already exist." will be displayed on the top right of the application.
#            
#           @ignore
#           scenario: 11 Test Update existing education detail  unsucessfull
#           Given  Given select college as "JNTU university"
#           And    select country of college as "India"
#           And    select Title as "B.Tech"
#           And    select enter Degree as "Computers"
#           And    select year as "2010"
#           When   clicks on Update action button
#           Then   Education should be added to your profile .The alert message ,"This information is already exist." will be displayed on the top right of the application.  
#           
#            @ignore
#            Scenario: 12 Test College/University Name as a blankfield unsucessfull
#            Given    seller leaves college as a blankfield
#            And      all fields filled
#            When     clicks  on add action button
#            Then     add education should throw an alert message,"Please enter all the fields" will be displayed on the top right of the application. 
#               

#             Scenario: 13 Test Delete Education sucessfully   
#	          When   seller select to delete certification "Illinoise university"
#	          Then   education should be deleted  .The alert message, "Education entry successfully removed" will be displayed on the top right of the application.
#
# CERTIFICATION:
#--------------------------

#                
#               Scenario: 14 Test Add Certifications sucessfully           
#	            Given  seller enter certification as "ISTQB certification"
#	            And    enter certified from  as "Global Talent"
#	            And    select Year as "2015"
#	            When   clicks on EduAdd action button
#	            Then   certification should be added to your profile .The alert message, "ISTQB certification has been added to your certification" will be displayed on the top right of the application.
#
#	              
#	           Scenario: 15 Test Update Certifications sucessfully
#	           Given     seller updates certification as "ADVANCED ISTQB certification"
#	           And       enter certified from  as "Global Talent"
#	           And       select Year as "2018"
#	           When      clicks on EduAdd action button
#	           Then      certification should be updated to your profile .The alert message, "ADVANCED ISTQB certification has been updated to your certification" will be displayed on the top right of the application.
#
#	          Scenario: 16 Test Delete Certifications sucessfully   
#	          When       seller select to delete certification "ADVANCED ISTQB certification"
#             Then       certification should be deleted  .The alert message, "ADVANCED ISTQB certification has been deleted from your certification" will be displayed on the top right of the application.
#        
#     
#              @ignore @web
#              Scenario: 17 Test blank cerification unsucessful
#              Given    seller enter certification as "jira certification"  
#              And      remaining fields are blank
#              When     clicks on add action button
#              Then     add education should throw an alret message," please enter certification name, certification from and certification year" will be displayed on the top right of the application. 
#
#               Scenario: 18 Test Add exixisting Certifications sucessfully           
#	            Given seller enter certification as "ISTQB certification"
#	            And enter certified from  as "Global Talent"
#	            And  select Year as "2015"
#	            When clicks on Add action button
#	            Then certification should be added to your profile .The alert message, "This information is already exist." will be displayed on the top right of the application.
#
#              Scenario: 19 Test update  exixisting Certifications sucessfully           
#	            Given seller enter certification as "ISTQB certification"
#	            And enter certified from  as "Global Talent"
#	            And  select Year as "2015"
#	            When clicks on update  action button
#	            Then certification should be added to your profile .The alert message, "This information is already exist." will be displayed on the top right of the application.
#
#
#  SELLER PROFILE NAME DROPDOWN:
#   ----------------------------------------
#                
#              Scenario: 20 test title dropdown to edit name
#              Given seller enter firstname as "harika"
#              and   last name as "thota
#              When clicks on 'save' action button
#              Then seller should be able to save name with changed first name and last name.
#
# 
# SELLER AVAILABILITY
# ----------------------

#             Scenario: 21 Test Add seller Availability sucessfully
#             Given select Availability as "Part Time"
#             Then Availability should be added to your profile.The alert message,"Availability updated" will be displayed on the top right of the application.
#
#     
#             Scenario: 22 Test Add  Availability sucessfully
#             Given select Availability as "Full Time"
#             Then Availability should be added to your profile.The alert message,"Availability updated" will be displayed on the top right of the application.
#
#              @mytag
#            Scenario: 23 Test Add Hours  sucessfully
#            Given select Hours as "More Than 30Hours a Week"
#            Then Hours should be added to your profile.The alert message,"Availability updated" will be displayed on the top right of the application.
#
#             @mytag
#             Scenario: 24 Test Add Earn Target sucessfully
#             Given select Earn Target as "Between $500 and $1000 per month"
#            Then  Earn Target should be added to your profile.The alert message,"Availability updated" will be displayed on the top right of the application.
#	



