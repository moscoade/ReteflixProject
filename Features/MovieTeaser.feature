Feature: MovieTeaser

A short summary of the feature


Scenario: Movie Teaser
	Given I navigate to reteflix website
	And I click to accept all cookies
	When I click on any movie teaser play now thumbnail on the home page
	And I click on play
	Then I should be able to watch the movie
