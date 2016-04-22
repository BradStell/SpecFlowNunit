Feature: Login
	In order to test specflow with nunit
	as a  ninja developer
	I need to get specflow tests to run with nunit

@login
Scenario: Login
	Given I am on the homepage
	When I press the Login link
	Then I should be taken to the login page
