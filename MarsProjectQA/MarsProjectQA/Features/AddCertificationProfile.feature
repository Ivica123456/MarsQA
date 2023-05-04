Feature: AddCertificationProfile

As a site user I would like to sign in,create ,edit the profile so
that seller would able to see profile deitals on the page. short summary of the feature

@tag1
Scenario: 01)Add certification on my profile
	Given I lanch and log into MarsQA portal successfully
	When I add a new certification
	Then Then the new certification should be added succesfully

	Scenario: 02)Edit certification on my profile
	Given I lanch and log into MarsQA portal successfully
	When I edited a new certification 
	Then Then a new certification should be edited

	Scenario: 03)Delete certification on my profile
	Given I lanch and log into MarsQA portal successfully
	When I deleted certification 
	Then Then certification should be deleted

	Scenario: 04)Add language on my profile
	Given I launch and log into MarsQA portal successfully
	When I add a new Language
	Then Then new language should be added successfully
Scenario: 05)Edit language on my profile
    Given I launch and log into MarsQA portal successfully
	When I edited a new language
    Then Then a new language should be edited successfully 
Scenario: 06)Delete language on my profile
    Given  I launch and log into MarsQA portal successfully
	When I deleted a language
	Then Then language should be deleted 

Scenario: 07)ADD Skills to my profile
	Given  I launch and log into MarsQA portal successfully
    When I add new Skill
	Then Then new Skill should be added successfully
Scenario: 08)Edit Skills to my profile
    Given I lanch and log into MarsQA portal successfully
    When I edited a new skill
    Then Then the new skill should be edited successfully

Scenario: 09)Delete Skills to my profile
    Given I lanch and log into MarsQA portal successfully
    When I deleted a new skill
    Then Then a new skill should be deleted successfully
