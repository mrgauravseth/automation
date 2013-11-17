Feature: Registration
DESCRIPTION: As a User i want to Open and register in the Mercury Tours Website
	
 @Priority:Medium
Scenario: Open the Mercury Tours Site
 Given I am on the site 'http://newtours.demoaut.com/'
 When user waits '5' second
 Then I should see the site title as 'Welcome: Mercury Tours'
 Then i close the Site

  @Priority:Medium
Scenario: Mercury Tours Registration
 Given I am on the site 'http://newtours.demoaut.com/mercuryregister.php'
 When user waits '5' second
 Then I should see the site title as 'Register: Mercury Tours'
 When I enter text 'Gaurav' in the TextBox 'firstName' searched by 'NAME'
 When I enter text 'Seth' in the TextBox 'lastName' searched by 'NAME'
 When I enter text '07542681208' in the TextBox 'phone' searched by 'NAME'
 #Below is Email
 When I enter text 'seth@gmail.com' in the TextBox 'userName' searched by 'NAME'
 When I enter text 'Basement Flat, 173 Belle Vue Road' in the TextBox 'address1' searched by 'NAME'
 When I enter text 'Leeds' in the TextBox 'city' searched by 'NAME'
 When I enter text 'West Yorkshire' in the TextBox 'state' searched by 'NAME'
 When I enter text 'LS3 1DU' in the TextBox 'postalCode' searched by 'NAME'
 When I enter text 'mrsethgaurav' in the TextBox 'email' searched by 'NAME'
 When I enter text 'letmein' in the TextBox 'password' searched by 'NAME'
 When I enter text 'letmein' in the TextBox 'confirmPassword' searched by 'NAME'
 When I click on the Button 'register' searched by 'NAME'
 Then i close the Site

  @Priority:Medium
Scenario: Login and then Logout Mercury Tours
Given I am on the site 'http://newtours.demoaut.com/'
Then I should see the site title as 'Welcome: Mercury Tours'
When I enter text 'mrsethgaurav' in the TextBox 'userName' searched by 'NAME'
When I enter text 'letmein' in the TextBox 'password' searched by 'NAME'
#When I click on the Image Button 'login' searched by 'NAME'
When I click on the Button 'login' searched by 'NAME'
Then I should see the site title as 'Find a Flight: Mercury Tours:'
When I click on the Link 'SIGN-OFF' searched by 'linkText'
Then i close the Site





