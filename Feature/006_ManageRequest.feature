Feature: 006_ManageRequest

A short summary of the feature

@TS_601_TC_001
Scenario: TS_601_TC_001 Verify the user click on Received requests dropdown and click accept
	Given I logged into Skill website successfully
	Given I create a listing
	Given I logout from Skill website
	Given I logged into Skill website with second user successfully
	When I search for a listing and send request
	When I logout from Skill website
	When I logged into Skill website with first user successfully
	When I click on Manage request dropdown and select Received requests
	When I click accept
	Then the listing status should change to complete on receive request


@TS_601_TC_002
Scenario: TS_601_TC_002 Verify the user click on Received requests dropdown and click decline
	Given I logged into Skill website successfully
	Given I create a listing
	Given I logout from Skill website
	Given I logged into Skill website with second user successfully
	When I search for a listing and send request
	When I logout from Skill website
	When I logged into Skill website with first user successfully
	When I click on Manage request dropdown and select Received requests
	When I click decline
	Then the listing status should change to declined


@TS_601_TC_003
Scenario: TS_601_TC_003 Verify the user click on send request dropdown and click completed button
	Given I logged into Skill website successfully
	Given I create a listing
	Given I logout from Skill website
	Given I logged into Skill website with second user successfully
	When I search for a listing and send request
	When I logout from Skill website
	When I logged into Skill website with first user successfully
	When I click on Manage request dropdown and select Received requests
	When I click completed
	When I logout from Skill website
	Given I logged into Skill website with second user successfully
	When I click on Manage request dropdown and select send requests
	When I click completed
	Then the listing status should change to review

	






