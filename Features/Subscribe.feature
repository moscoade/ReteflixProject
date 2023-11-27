Feature: Subscribe

A short summary of the feature


Scenario: Subscribe Button
	Given I navigate to reteflix website
	And I click to accept all cookies
	When I click on subscribe button on the footer
	And I enter my name
	And I enter my email address
	When I click on subscribe
	Then I should see subscription message displayed "Subscription successful. We will be in touch shortly."
	
