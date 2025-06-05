Feature: Login

A short summary of the feature

Background: 

	Given User is on the orangehrm login page
 
@Regression,@Functional

Scenario: Verify login with valid credentails

	When User enters the username "Admin" and password "admin123" in the text fields

	When User clicks on submit button

	Then User is navigated to home page
 

	@Sanity
	Scenario Outline: Verify Login with diff test parameters valid credentails
	Given User is on the orange hrm login page
	When User enters the "<username>" and "<password>"
	And   User clicks on submit button

    Then User is navigated to home page
	Then User selected city and country informatiion
	| city      | country |
	| bengaluru | india   |
	| mangalore | india   |
		Examples: 
	| username | password |
	| Admin    | admin123 |
	| Ad       | adn      |
	| Adm      | an       |

