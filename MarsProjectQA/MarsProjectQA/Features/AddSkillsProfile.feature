Feature: AddSkillsProfile

A short summary of the feature

@tag1
Scenario: ADD Skills to my profile
	Given  I launch and log into MarsQA portal successfully
    When I add new Skill
	Then Then new Skill should be added successfully
Scenario: Edit Skills to my profile
Given I lanch and log into MarsQA portal successfully
When I edited a new skill
Then Then the new skill should be edited successfully

Scenario: Delete Skills to my profile
Given I lanch and log into MarsQA portal successfully
When I deleted a new skill
Then Then a new skill should be deleted successfully

