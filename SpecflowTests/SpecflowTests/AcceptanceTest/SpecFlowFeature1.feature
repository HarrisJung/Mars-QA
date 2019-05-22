Feature: Seller -> Add Profile Details
Priority: Major
As a Seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.

#Adding my profile details
Scenario Outline: Check if user could able to add languages
	Given I clicked on the Langauge tab under Profile page
	When I add new languages <language>
	Then those languages <language> should be displayed on my listings

	Examples:
		| language |
		| English  |
		| Korean   |
		| Chinese  |

Scenario Outline: Check if user could able to add skills
	Given I clicked on the Skills tab under profile page
	When I add new skills <skill>
	Then those skills <skill> should be displayed on my listings

	Examples:
		| skill    |
		| Selenium |
		| JIRA     |
		| Cucumber |

Scenario Outline: Check if user could able to add educations
	Given I clicked on the Educations tab under profile page
	When I add new educations <education> and <degree>
	Then those educations <educations> and <degree> should be displayed on my listings

	Examples:
		| education           | degree   |
		| Cornell             | Bachelor |
		| Industry Connect    | Diploma  |
		| Auckland University | Master   |

Scenario Outline: Check if user could able to add certifications
	Given I clicked on the Certifications tab under profile page
	When I add new certification <certification> and <from>
	Then those certifications should be displayed on my listings

	Examples:
		| certification                              | from  |
		| Foundation Certificate in Software Testing | ISTQB |
		| Network Certificate                        | Cisco |
		| Security Certificate in Software Testing   | NZQA  |

Scenario: Check if user could able to add a language
	Given I clicked on the Language tab under Profile page
	When I add a new language
	Then that language should be displayed on my listings

Scenario: Check if user could able to add a skill
	Given I clicked on the Skills tab under Profile page
	When I add a new skill
	Then that skill should be displayed on my listings

Scenario: Check if user could able to add a education
	Given I clicked on the Education tab under Profile page
	When I add a new education
	Then that education should be displayed on my listings

Scenario: Check if user could able to add a certification
	Given I clicked on the Certifications tab under Profile page
	When I add a new certificate
	Then that certificate should be displayed on my listings

#Editing my profile details
Scenario: Check if user could able to edit a language
	Given I clicked the pencil icon on my listings under Profile page
	When I edit a skill
	Then that updated language should be displayed on my listings

Scenario: Check if user could able to edit a skill
	Given I clicked the pencil icon on my listings under Profile page
	When I edit a language
	Then that updated skill should be displayed on my listings

Scenario: Check if user could able to edit a education
	Given I clicked the pencil icon on my listings under Profile page
	When I edit a language
	Then that updated education should be displayed on my listings

Scenario: Check if user could able to edit a certification
	Given I clicked the pencil icon on my listings under Profile page
	When I edit a language
	Then that updated certification should be displayed on my listings

#deleting my profile details
Scenario: Check if user could able to delete a language
	Given the language which I have added should be displayed on my listings under Profile page
	When I click the X icon on my listings
	Then that language should be deleted from my listings

Scenario: Check if user could able to delete a skill
	Given the skill which I have added should be displayed on my listings under Profile page
	When I click the X icon on my listings
	Then that skill should be deleted from my listings

Scenario: Check if user could able to delete a education
	Given the education which I have added should be displayed on my listings under Profile page
	When I click the X icon on my listings
	Then that education should be deleted from my listings

Scenario: Check if user could able to delete a certification
	Given the certification which I have added should be displayed on my listings under Profile page
	When I click the X icon on my listings
	Then that certification should be deleted from my listings

#Writing my description
Scenario: Check if user could able to write a description
	Given I clicked the pencil icon next to description under profile page
	When I write about my information
	Then that information should be displayed on description section

Scenario: Check if user could able to set details of availability, Hours and Earn Target under profile page
	Given I clicked the pencil icon next to Availability

#Adding a shared skill
Scenario: Check if user could able to add a Shared Skill on my listings
	Given I clicked on the button Share Skill under Profile page
	When I add a new shared skill
	Then the lists of shared skill you have been posting should be displayed on my listings

#Editing a shared skill
Scenario: Check if user could able to edit a Shared Skill on my listings
	Given I clicked on the Manage Listings tab under Profile page
	When I clicked the pencil icon on my listings
	And I edit a shared skill
	Then that updated shared skill should be displayed  on my listings

#Deleting a shared skill
Scenario: Check if user could able to delete a Shared Skill on my listings
	Given I clicked on the Manage Listings tab under Profile page
	When I clicked the X icon on my listings
	And I clicked the button Yes on Alert page
	Then that shared skill should be deleted from my listings

#The ways of that people could able to look into my details
Scenario: Check if people could able to look into my details by searching skillname
	Given people type skill name on the search bar for 'Test Analyst'
	When people click my Info on a result of user's search
	Then the details of my shared skill should be displayed

Scenario: Check if people could able to look into my details by exploring categories
	Given the categories should be displayed on the homepage
	When people click Programming & Tech on the category
	And people click QA under the category of Programming & Tech
	And people click my Info on a result of user's search
	Then the details of my shared skill should be displayed

Scenario: Check if people could able to look into my details by searching username
	Given the categories should be displayed on the homepage
	When people fill username on username search bar for "harris jung"
	Then the details of my shared skill should be displayed

#The ways of that people could able to contact with seller
Scenario: Check if people could able to contact with seller by chat
	Given people should be able to read seller's  Info
	When people click the button chat
	Then the chat room should be opened to seller and people both of them

Scenario: Check if people could able to leave a message to seller
	Given people should be able to read seller's Info
	When people leave a message to the seller
	Then that message should be sent to the seller and then, seller should able to read user's message