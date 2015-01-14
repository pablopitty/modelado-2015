Feature: Reviews
	In order to promote the best restaurants
	As Chef Juan
	I want to register my reviews

Scenario: Reviewing a restaurant
	Given a restaurant called NachosPlace
	When ChefJuan rates it 5 stars
	Then it shows up in the restaurant reviews list with 5 stars from ChefJuan

	
	Scenario: A new review from other person
	Given a restaurant called NachosPlace
	When Ivonne rates it 3 stars
	Then it shows up in the restaurant reviews list with 3 stars from Ivonne

Scenario: Reviewing a restaurant again is forbidden
	Given a restaurant called NachosPlace
	When ChefJuan rates it 5 stars
	And ChefJuan tries to rate it a second time 2 stars
	Then it shows up in the restaurant reviews list with 5 stars from ChefJuan