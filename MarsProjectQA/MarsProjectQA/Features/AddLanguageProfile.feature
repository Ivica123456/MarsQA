Feature: AddLanguageProfile

As a site user I would like to sign in,create ,edit the profile so
that seller would able to see profile deitals on the page.

@tag1
Scenario: Add language on my profile
	Given I launch and log into MarsQA portal successfully
	When I add a new Language
	Then Then new language should be added successfully
