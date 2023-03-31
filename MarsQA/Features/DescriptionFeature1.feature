Feature: DescriptionFeature1

Seller ADD Description


@tag1
Scenario: ADD my Description
	Given I came to the website
	When I navigate to the Profile page
	And I create new Description
	Then Description should be created successfully

Scenario Outline: Edit existing Certification Name with valid details
Given I came to the website
When I navigate to the Profile page
And I updated '<CertificationName>', on existing Description record
Then Then the record should be created successfully '<CertificationName>'


Examples: 
| CertificationName        |
| NetRiders Challenge 2012 |