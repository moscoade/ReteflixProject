Feature: ContactUs

A short summary of the feature


Scenario: Contact Us
	Given I navigate to reteflix website
	And I click on contact Us on the footer
	When the contact us form is displayed
	And I enter my first name
	And I enter my last name
	And I enter my email address
	And I enter my messages
	When I click on send message
	Then I should see a message displayed "Message successfully sent."


