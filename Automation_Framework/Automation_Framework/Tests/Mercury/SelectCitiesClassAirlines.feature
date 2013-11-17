Feature: SelectCitiesAndClass
DESCRIPTION: As a User i should be able to select different Cities and Various Travel Class Types using Any Airlines

  @Priority:Medium
Scenario: Cities, Class, Airlines
Given I am on the site 'http://newtours.demoaut.com/'
Then I should see the site title as 'Welcome: Mercury Tours'
When I enter text 'mrsethgaurav' in the TextBox 'userName' searched by 'NAME'
When I enter text 'letmein' in the TextBox 'password' searched by 'NAME'
When I click on the Button 'login' searched by 'NAME'
Then I should see the site title as 'Find a Flight: Mercury Tours:'
When I select drop down value 'London' from the DropDown Box 'fromPort' searched by 'XPATH'
When I select drop down value 'New York' from the DropDown Box 'toPort' searched by 'XPATH'
When user selects Radio Button Value 'Business class' from RadioButtonGroup 'Business' searched by 'CSS'
When I click on the Button 'findFlights' searched by 'NAME'
And user takes Screenshot
Then i close the Site

