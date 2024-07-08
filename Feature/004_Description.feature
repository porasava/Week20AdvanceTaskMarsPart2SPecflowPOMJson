Feature: 004_Description

A short summary of the feature

@TS_400_TC_001
Scenario: TS_400_TC_001 Verify that the user edit description on the account profile page
	Given I logged into Skill website successfully 
	When I edit the Description
	Then The description should be edited successfully
	Then I revert the Description back to itd original state
