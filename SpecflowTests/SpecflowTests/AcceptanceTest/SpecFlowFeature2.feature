Feature: Test the system response from invalid input or unexpected user behaviour
during the processing of that seller -> add profile details and then people could able to look into seller's profile details
As a software tester
I want to ensure that your application can gracefully handle invalid input or unexpected user behavior.

@mytag
#Login
Scenario: Check response when invalid email and password is entered
	Given I clicked the button Sign In
	When I entered invalid email and password
	Then it should be not logged in and displayed alert message user to send verification email

#Profile page
Scenario: Check response when it is over number of characters remaining on description text area under profile page
	Given I clicked the pencil icon next to description under profile page
	When I write over number of characters remaining on description text area
	Then it should be blocked to write when the maximum character size is exceeded

Scenario: Check response when it is empty on the field during adding a language on profile page
	Given I clicked on the Languages tab under profile page
	When I entered nothing on the language field
	Then it shoud be not added and displayed alert message to fill the empty field

Scenario: Check response when it is empty on the field during adding a skill on profile page
	Given I clicked on the Skills tab under profile page
	When I entered nothing on the skill field
	Then it shoud be not added and displayed alert message to fill the empty field

Scenario: Check response when it is empty on the field during adding a education on profile page
	Given I clicked on the Educations tab under profile page
	When I entered nothing on the education field
	Then it shoud be not added and displayed alert message to fill the empty field

Scenario: Check response when it is empty on the field during adding a certification on profile page
	Given I clicked on the Certifications tab under profile page
	When I entered nothing on the certificate field
	Then it shoud be not added and displayed alert message to fill the empty field

Scenario: Check response when a langauge is already exist in the language list on profile page
	Given I clicked on the Languages tab under profile page
	When I entered a language which is already exist
	Then it shoud be not added and displayed alert message that This language is already exist in your language list.

Scenario: Check response when a skill is already exist in the language list on profile page
	Given I clicked on the Skills tab under profile page
	When I entered a skill which is already exist
	Then it shoud be not added and displayed alert message that This skill is already exist in your skill list.
Scenario: Check response when a education is already exist in the language list on profile page
	Given I clicked on the Educations tab under profile page
	When I entered a education which is already exist
	Then it shoud be not added and displayed alert message that This information is already exist.
	Scenario: Check response when a certification is already exist in the language list on profile page
	Given I clicked on the Certifications tab under profile page
	When I entered a certification which is already exist
	Then it shoud be not added and displayed alert message that This information is already exist.
#Share skill application page
Scenario: Check response when it is empty on the field during adding a shared skill on share skill application form page
	Given I clicked on the button Share Skill under profile page
	When I entered nothing on the field
	Then it should be rejected with alert message to fill the empty fields which are necessary to write

Scenario: Check response when the types of word are out of scope such as Korean and special characters on share skill application form page
	Given I clicked on the button Share Skill under profile page
	When I entered korean and special characters on the field under share skill application form page
	Then it should be not accepted with alert message to use English alphabet or a number

Scenario: Check response when sets the Start date or End date in the past
	Given I clicked on the button Share Skill under profile page
	When I set past date for Start date or End date
	Then it should be stopped with alert message to warn that it cannot be set to a day in the past

Scenario: Check response when file is uploaded which file size is over 2mb or the types which is not supported
	Given I clicked on the button Share Skill under profile page
	When I upload the file which size is over 2mb
	And I upload the file which the types are not supported
	Then it should be stopped with alert message that Max file size is 2 MB and supported file types are gif / jpeg / png / jpg / doc(x) / pdf / txt / xls(x)

#Search seller's profile details
Scenario: Check response when search result is not found
	Given search bar should be displayed on the website
	When I search a thing which is not searchable
	Then it should be displayed the message No results found, please select a new category! on the website

	Scenario: Check response when shared skill Info is turned deactivated
	Given A shared skill Info which is I created should be displayed on Manage Listings under ListingManagement page
	When I clicked the button Active to deactive
	Then it should be not searchable by the others