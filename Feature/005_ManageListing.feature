Feature: 005_ManageListing

A short summary of the feature

	@TS_501_TC_001
	Scenario: TS_501_TC_001 Verify the user click on edit listing link on manage listings page
	Given I logged into Skill website successfully 
	Given I created a listing
	When I edit listing
	Then It should show the listing update on the listing detail page


	@TS_501_TC_002
	Scenario: TS_501_TC_002 Verify the user click on see listing link on manage listings page
	Given I logged into Skill website successfully 
	When I navigate to Manage listing page
	When I click on see listing
	Then It should show the listing on the listing detail page


	@TS_501_TC_003
	Scenario: TS_501_TC_003 Verify the user click on delete listing link on manage listings page
	Given I logged into Skill website successfully 
	When I navigate to Manage listing page
	When I click on delete listing
	Then The listing should be delete successfully



	@TS_501_TC_005
	Scenario: TS_501_TC_005 Verify the user click on activate listing link on manage listings page
	Given I logged into Skill website successfully 
	When I navigate to Manage listing page
	When I click on Deactivate listing 
	When I click on activate listing 
	Then It should show Service has been activated

	@TS_501_TC_006
	Scenario: TS_501_TC_006 Verify the user click on Deactivate listing link on manage listings page
	Given I logged into Skill website successfully 
	When I navigate to Manage listing page
	When I click on Deactivate listing 
	Then It should show Service has been deactivated
	When I click on activate listing 


