Feature: Login
Check if login functionality works


@mytag
Scenario: Login user as Administrator
	Given I navigate to application
	And I enter username and password
		| User     | Password |
		| admin    | 1234     |
	And I click login
	Then the system displays the main page