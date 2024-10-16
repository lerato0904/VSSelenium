Feature: RegisterUser

Register a new user for automationexercise website

@tag1
Scenario: [Sign Up New User]
	Given [Automation exercise URL]
	When [Verify that home page is visible successfully]
	And  Click on Signup / Login button
	And Enter signup username
	And Enter signup email address
	And Click on Signup button
	Then Confirm User is successfully signed up
