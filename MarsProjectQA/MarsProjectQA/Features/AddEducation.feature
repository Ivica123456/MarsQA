﻿Feature: AddEducation

A short summary of the feature

@tag1
Scenario Outline: I Add Education on my profile
	Given I lanch and log into MarsQA portal successfully
	When When I add my education including '<Country>', '<University>', '<Title>', '<Degree>','<Graduation>'
	Then Then I am able to see my education details including '<Country>', '<University>', '<Title>', '<Degree>','<Graduation>'

	Examples: 
	| Country     | University | Title | Degree  | Graduation |
	| Croatia     | EduNet     | M.A   | Diploma | 2012       |
	| New Zealand | EduNet     | M.A   | Diploma | 2023       |
