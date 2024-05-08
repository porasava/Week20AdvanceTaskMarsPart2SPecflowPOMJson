Feature: 002_Education

A short summary of the feature


@TS_201_TC_001
	Scenario: TS_201_TC_001 Verify that the user can't add an Education on the account profile page with blank on 'college' field left blank
	Given I logged into Skill website successfully 
	Given I checked existing Education
	When I attempt to add a new Education with College Field left blank 
	Then an error message should be displayed: Please enter all fields


	@TS_201_TC_002
	Scenario: TS_201_TC_002 Verify that the user can't add an Education on the account profile page with the 'Country' field left blank
	Given I logged into Skill website successfully 
	And I have checked existing Education entries
	When I attempt to add a new Education with the Country field left blank 
	Then an error message should be displayed: Please enter all fields

	@TS_201_TC_003
	Scenario: TS_201_TC_003 Verify that the user can't add an Education on the account profile page with the 'Title' field left blank
	Given I logged into Skill website successfully 
	And I have checked existing Education entries
	When I attempt to add a new Education with the Title field left blank 
	Then an error message should be displayed: Please enter all fields


@TS_201_TC_004
Scenario: TS_201_TC_004 Verify that the user can't add an Education on the account profile page with the 'Degree' field left blank
	Given I logged into Skill website successfully 
	And I have checked existing Education entries
	When I attempt to add a new Education with the Degree field left blank 
	Then an error message should be displayed: Please enter all fields

@TS_201_TC_005
Scenario: TS_201_TC_005 Verify that the user can't add an Education on the account profile page with the 'Year of Graduation' field left blank
	Given I logged into Skill website successfully 
	And I have checked existing Education entries
	When I attempt to add a new Education with the Year of Graduation field left blank 
	Then an error message should be displayed: Please enter all fields

@TS_201_TC_006
Scenario: TS_201_TC_006 Verify that the user can add an Education on the account profile page and then click on cancel
	Given I logged into Skill website successfully 
	And I have checked existing Education entries
	When I add a new Education entry
	Then I click cancel


@TS_201_TC_007
Scenario: TS_201_TC_007 Verify that the user can add an Education on the account profile page with special characters in the 'College' field
	Given I logged into Skill website successfully 
	And I have checked existing Education entries
	When I add a new Education with special characters in the College field
	Then the Education entry should be added successfully
	And I delete an Education entry
	Then the Education entry should be deleted successfully

@TS_201_TC_008
Scenario: TS_201_TC_008 Verify that the user can add an Education on the account profile page with more than 50 letters in the 'College' field
	Given I logged into Skill website successfully 
	And I have checked existing Education entries
	When I add a new Education with more than letters in the College field
	Then the Education entry should be added successfully
	And I delete an Education entry
	Then the Education entry should be deleted successfully



@TS_201_TC_009
Scenario: TS_201_TC_009 Verify that the user can add an Education on the account profile page with more than 50 letters in the 'Degree' field
	Given I logged into Skill website successfully 
	And I have checked existing Education entries
	When I add a new Education with more than letters in the Degree field
	Then the Education entry should be added successfully
	And I delete an Education entry
	Then the Education entry should be deleted successfully


@TS_201_TC_010
Scenario: TS_201_TC_010 Verify that the user can't add an Education on the account profile page with duplicate education details
	Given I logged into Skill website successfully 
	And I have checked existing Education entries
	When I add a new Education entry
	Then the Education entry should be added successfully
	When I attempt to add a duplicate Education entry
	Then an error message should be displayed: This information already exists
	And I delete an Education entry
	Then the Education entry should be deleted successfully

@TS_202_TC_001
Scenario:TS_202_TC_001 Verify that the user delete an Education on the account profile page
	Given I logged into Skill website successfully 
	Given I checked existing Education
	When I add a new Education entry
	Then Education should be add successfully
	Then I deleted an Education
	Then Education should be delete successfully






