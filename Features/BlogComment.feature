Feature: BlogComment

A short summary of the feature

Scenario: Blog Comment
	Given I navigate to reteflix website
	And I click to accept all cookies
	When I click on blog on the menu
	And I click on any blog post at rondom
	And I enter comments
	And I enter author name
	And I enter author email address
	And I enter author website
	And I tick the box to save my name
	When I click post comment
	Then my comment should be posted

