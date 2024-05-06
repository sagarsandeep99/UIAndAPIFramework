Feature: LoginToContactListAppFromExternalData

Read data from external source documents

@UiTests
Scenario Outline: Login to Contact List Application(CLA) by reading data from excel file
	Given user1 launches the browser_createUserRequest
	| Browsers  |
	| <Browser> |
	And user1 naivagtes to CLA portal <AppURL>
	And user1 enters username and password in CLA
	When user1 logs in to Contact List app
	Then user1 should be logged in and and navigate to Home Page of CLA

Examples: 

| Browser | AppURL                                                |
| chrome  | "https://thinking-tester-contact-list.herokuapp.com/" |
| firefox | "https://thinking-tester-contact-list.herokuapp.com/" |
| edge    | "https://thinking-tester-contact-list.herokuapp.com/" |
#| safari |  "https://thinking-tester-contact-list.herokuapp.com/" |


@UiTests
Scenario Outline: Login to Contact List Application(CLA) by reading data from csv file
	Given user1 launches the browser
	| Browsers  |
	| <Browser> |
	And user1 naivagtes to CLA portal <AppURL>
	And user1 enters username and password in CLA
	When user1 logs in to Contact List app
	Then user1 should be logged in and and navigate to Home Page of CLA

Examples: 

| Browser | AppURL                                                |
| chrome  | "https://thinking-tester-contact-list.herokuapp.com/" |
| firefox | "https://thinking-tester-contact-list.herokuapp.com/" |
| edge    | "https://thinking-tester-contact-list.herokuapp.com/" |
#| safari |  "https://thinking-tester-contact-list.herokuapp.com/" |


@UiTests
Scenario Outline: Login to Contact List Application(CLA) by reading data from xml file
	Given user1 launches the browser
	| Browsers  |
	| <Browser> |
	And user1 naivagtes to CLA portal <AppURL>
	And user1 enters username and password in CLA
	When user1 logs in to Contact List app
	Then user1 should be logged in and and navigate to Home Page of CLA

Examples: 

| Browser | AppURL                                                |
| chrome  | "https://thinking-tester-contact-list.herokuapp.com/" |
| firefox | "https://thinking-tester-contact-list.herokuapp.com/" |
| edge    | "https://thinking-tester-contact-list.herokuapp.com/" |
#| safari |  "https://thinking-tester-contact-list.herokuapp.com/" |