Feature: SearchFuntionality

A short summary of the feature


Scenario: Search
	Given I navigate to reteflix website
	When I click on search icon on the header menu
	And I ender a movie name in the search box
	When I click on search button
	Then my movie should be displayed
