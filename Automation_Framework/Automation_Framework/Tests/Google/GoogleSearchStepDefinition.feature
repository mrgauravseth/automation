Feature: Google Search.feature
Description: 
 As an end user,
 I would like to visit the google search page
 And then I would like to search an item so that
 I can view the search results

 Background: User Open 'firefox' browser

@Priority:Medium
Scenario: Google Search

 Given I am on the site 'http://www.google.com'
 When I enter text 'Selenium Automation' in the TextBox 'q' searched by 'NAME'
 When user waits '5' second
 Then I should see the site title as 'Selenium Automation - Google Search'
 Then i close the Site

