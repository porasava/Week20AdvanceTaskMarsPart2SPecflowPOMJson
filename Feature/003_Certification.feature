Feature: 003_Certification

A short summary of the feature

@TS_301_TC_001
Scenario: TS_301_TC_001 Verify that the user add a Certification on the account profile page with correct mandatory field
	Given I logged into Skill website successfully 
	And I have checked existing Certification entries
	When I have add new certification
	Then Pop up should be add successfully
	Then I have Delete a certification
	Then Pop up Certification should delete successfully


@TS_301_TC_002
Scenario:TS_301_TC_002 Verify that the user add a Certification on the account profile page with incorrect mandatory field
	Given I logged into Skill website successfully 
	And I have checked existing Certification entries
	When I have add new certification
	Then Pop up Please Enter Certification Name Certification From And Certification Year


@TS_301_TC_003
Scenario:TS_301_TC_003 Verify that the user add a Certification on the account profile page with blank on certification field
	Given I logged into Skill website successfully 
	And I have checked existing Certification entries
	When I have add new certification
	Then Pop up Please Enter Certification Name Certification From And Certification Year

@TS_301_TC_004
Scenario:TS_301_TC_004 Verify that the user add a Certification on the account profile page with blank on certified from field
	Given I logged into Skill website successfully 
	And I have checked existing Certification entries
	When I have add new certification
	Then Pop up Please Enter Certification Name Certification From And Certification Year


	@TS_301_TC_005
Scenario:TS_301_TC_005 Verify that the user add a Certification on the account profile page with blank on year field
	Given I logged into Skill website successfully 
	And I have checked existing Certification entries
	When I have add new certification
	Then Pop up Please Enter Certification Name Certification From And Certification Year


	@TS_301_TC_006
Scenario:TS_301_TC_006 Verify that the user adds a certification to the account profile page with more than 50 letters in the certification field
	Given I logged into Skill website successfully 
	And I have checked existing Certification entries
	When I have add new certification
	Then Pop up should be add successfully
	Then I have Delete a certification
	Then Pop up Certification should delete successfully

	@TS_301_TC_007
Scenario:TS_301_TC_007 Verify that the user adds a certification to the account profile page with more than 50 letters in the certified from field
	Given I logged into Skill website successfully 
	And I have checked existing Certification entries
	When I have add new certification
	Then Pop up should be add successfully
	Then I have Delete a certification
	Then Pop up Certification should delete successfully

	@TS_302_TC_001 
Scenario:TS_302_TC_001 Verify that the user delete a Certification on the account profile page
	Given I logged into Skill website successfully 
	And I have checked existing Certification entries
	When I have add new certification
	Then Pop up should be add successfully
	Then I have Delete a certification
	Then Pop up Certification should delete successfully
