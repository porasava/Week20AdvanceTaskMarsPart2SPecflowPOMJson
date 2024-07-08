Feature: 001_Password

A short summary of the feature

@TS_100_TC_001
Scenario: TS_100_TC_001 Verify change Password on account Setting page
	Given I logged into Skill website successfully
	When I navigate to password pop up 
	When I change password
	Then It should show pop up Password Changed Successfully
	Then I change password back 