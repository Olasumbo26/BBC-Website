Feature: Eastenders
    As a BBC website user
	I want to be able to find out 
	about the next episode of Eastenders

	

@mytag
Scenario: Search Eastenders
	Given I Navigate to the site
	When I click on search text box
	And  I Enter Eastenders into the search text box
	And I Click on search button
	And I Click on Eastenders display image
	Then I should be able to find next episode 

