Feature: SearchFunctionality

A short summary of the feature


Scenario: Search
	Given I navigate to reteflix website
	And I click to accept all cookies
	When I click on search icon on the header menu
	And I ender a movie name in the search box
	When I click on search button
	Then my movie should be displayed
