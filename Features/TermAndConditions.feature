Feature: TermAndConditions

A short summary of the feature


Scenario: Terms&Conditions
	Given I navigate to reteflix website
	And I click to accept all cookies
	When I click on Terms and Conditions on the footer
	Then Terms and conditions page should be displayed
