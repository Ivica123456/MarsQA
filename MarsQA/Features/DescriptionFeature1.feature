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
And I updated '<CertificationName>','<putDescription>' on existing Description record
Then Then the record should be created successfully '<CertificationName>','<putDescription>'


Examples: 
| CertificationName        | putDescription                          |
| NetRiders Challenge 2012 | I like to read, I like to write; I like |

Scenario Outline: Delete existing Certification 
Given I came to the website
When I navigate to the Profile page
And I deleted existing Certification
Then Then the Certification should be deleted