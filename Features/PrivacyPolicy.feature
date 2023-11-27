Feature: PrivacyPolicy

A short summary of the feature


Scenario: PrivacyPolicy
	Given I navigate to reteflix website
	And I click to accept all cookies
	When I click on Privacy Policy on the footer
	Then Privacy policy page should be displayed
