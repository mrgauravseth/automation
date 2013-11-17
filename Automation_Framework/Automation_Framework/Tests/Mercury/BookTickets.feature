Feature: Book Tickets
DESCRIPTION: As a User i should be able to complete the Ticket Booking Process and be able to book a ticket successfully

@Priority:Medium
Scenario: Book Tickets - Use NAME Locators
Given I am on the site 'http://newtours.demoaut.com/'
When I enter text 'mrsethgaurav' in the TextBox 'userName' searched by 'NAME'
When I enter text 'letmein' in the TextBox 'password' searched by 'NAME'
When I click on the Button 'input[type='image'][alt='Sign-In']' searched by 'CSS'
Then I should see the site title as 'Find a Flight: Mercury Tours:'
When I select drop down value 'London' from the DropDown Box 'fromPort' searched by 'XPATH'
When I select drop down value 'New York' from the DropDown Box 'toPort' searched by 'XPATH'
When user selects Radio Button Value 'Business class' from RadioButtonGroup 'Business' searched by 'NAME'
When I click on the Button 'findFlights' searched by 'NAME'
Then i close the Site


@Priority:Medium
Scenario: Book Tickets - Use CSS Locators
Given I am on the site 'http://newtours.demoaut.com/'
Then I should see the site title as 'Welcome: Mercury Tours'
When I enter text 'mrsethgaurav' in the TextBox 'input[name='userName'][type='text']' searched by 'CSS'
When I enter text 'letmein' in the TextBox 'input[name='password'][type='password']' searched by 'CSS'
When I click on the Button 'input[type='image'][alt='Sign-In']' searched by 'CSS'
Then I should see the site title as 'Find a Flight: Mercury Tours:'
When I select drop down value 'London' from the DropDown Box 'select[name='fromPort']' searched by 'CSS'
When I select drop down value 'New York' from the DropDown Box 'select[name='toPort']' searched by 'CSS'
When user selects Radio Button Value 'Business class' from RadioButtonGroup 'input[type='radio'][value='Business']' searched by 'CSS'
When I click on the Button 'input[type='image'][name='findFlights'][src='/images/forms/continue.gif']' searched by 'CSS'
When I click on the Button 'input[type='image'][name='reserveFlights'][src='/images/forms/continue.gif']' searched by 'CSS'
# Enter the Passenger details
When I enter text 'Arti' in the TextBox 'input[name='passFirst0']' searched by 'CSS'
When I enter text 'Seth' in the TextBox 'input[name='passLast0']' searched by 'CSS'
When I select drop down value 'Vegetarian' from the DropDown Box 'select[name='pass.0.meal']' searched by 'CSS'
When I select drop down value 'MasterCard' from the DropDown Box 'select[name='creditCard']' searched by 'CSS'
When I enter text '123456789' in the TextBox 'input[name='creditnumber'][type='text']' searched by 'CSS'
When I select drop down value '12' from the DropDown Box 'select[name='cc_exp_dt_mn']' searched by 'CSS'
When I select drop down value '2010' from the DropDown Box 'select[name='cc_exp_dt_yr']' searched by 'CSS'
When I enter text 'Gaurav' in the TextBox 'input[name='cc_frst_name'][type='text']' searched by 'CSS'
When I enter text 'Seth' in the TextBox 'input[name='cc_last_name'][type='text']' searched by 'CSS'
#
When I turn the CheckBox 'input[type='checkbox'][name='ticketLess']' searched by 'CSS' to 'ON'
When I enter text '16, Dashmesh Avenue, PORS Mills' in the TextBox 'input[name='billAddress1']' searched by 'CSS'
When I enter text 'Amritsar' in the TextBox 'input[name='billCity']' searched by 'CSS'
When I enter text 'Punjab' in the TextBox 'input[name='billState']' searched by 'CSS'
When I select drop down value 'INDIA' from the DropDown Box 'select[name='billCountry']' searched by 'CSS'
#
When I enter text 'Basement Flat, 173 Belle Vue Road' in the TextBox 'input[name='delAddress1']' searched by 'CSS'
When I enter text 'Leeds' in the TextBox 'input[name='delCity']' searched by 'CSS'
When I enter text 'West Yorkshire' in the TextBox 'input[name='delState']' searched by 'CSS'
When I enter text 'LS3 1DU' in the TextBox 'input[name='delZip']' searched by 'CSS'
#
When I click on the Button 'input[type='image'][name='buyFlights'][src='/images/forms/purchase.gif']' searched by 'CSS'
Then i close the Site


@Priority:Medium
Scenario: Book Tickets - Use XPATH
Given I am on the site 'http://newtours.demoaut.com/'
Then I should see the site title as 'Welcome: Mercury Tours'
When I enter text 'mrsethgaurav' in the TextBox '//input[@name='userName']' searched by 'XPATH'
When I enter text 'letmein' in the TextBox '//input[@name='password'][@type='password']' searched by 'XPATH'
When I click on the Button '//input[@type='image'][@alt='Sign-In']' searched by 'XPATH'
Then I should see the site title as 'Find a Flight: Mercury Tours:'
When I select drop down value 'London' from the DropDown Box '//select[@name='fromPort']' searched by 'XPATH'
When I select drop down value 'New York' from the DropDown Box '//select[@name='toPort']' searched by 'XPATH'
When user selects Radio Button Value 'Business class' from RadioButtonGroup '//input[@type='radio'][@value='Business']' searched by 'XPATH'
When I click on the Button '//input[type='image'][@name='findFlights']' searched by 'XPATH'
When I click on the Button '//input[type='image'][@name='reserveFlights']' searched by 'XPATH'
# Enter the Passenger details
When I enter text 'Arti' in the TextBox '//input[@name='passFirst0']' searched by 'XPATH'
When I enter text 'Seth' in the TextBox '//input[@name='passLast0']' searched by 'XPATH'
When I select drop down value 'Vegetarian' from the DropDown Box '//select[@name='pass.0.meal']' searched by 'XPATH'
When I select drop down value 'MasterCard' from the DropDown Box '//select[@name='creditCard']' searched by 'XPATH'
When I enter text '123456789' in the TextBox '//input[@name='creditnumber'][@type='text']' searched by 'XPATH'
When I select drop down value '12' from the DropDown Box '//select[@name='cc_exp_dt_mn']' searched by 'XPATH'
When I select drop down value '2010' from the DropDown Box '//select[@name='cc_exp_dt_yr']' searched by 'XPATH'
When I enter text 'Gaurav' in the TextBox '//input[@name='cc_frst_name'][@type='text']' searched by 'XPATH'
When I enter text 'Seth' in the TextBox '//input[@name='cc_last_name'][@type='text']' searched by 'XPATH'
#
When I turn the CheckBox '//input[@type='checkbox'][@name='ticketLess']' searched by 'XPATH' to 'ON'
When I enter text '16, Dashmesh Avenue, PORS Mills' in the TextBox '//input[@name='billAddress1']' searched by 'XPATH'
When I enter text 'Amritsar' in the TextBox '//input[@name='billCity']' searched by 'XPATH'
When I enter text 'Punjab' in the TextBox '//input[@name='billState']' searched by 'XPATH'
When I select drop down value 'INDIA' from the DropDown Box '//select[@name='billCountry']' searched by 'XPATH'
#
When I enter text 'Basement Flat, 173 Belle Vue Road' in the TextBox '//input[@name='delAddress1']' searched by 'XPATH'
When I enter text 'Leeds' in the TextBox '//input[@name='delCity']' searched by 'XPATH'
When I enter text 'West Yorkshire' in the TextBox '//input[@name='delState']' searched by 'XPATH'
When I enter text 'LS3 1DU' in the TextBox '//input[@name='delZip']' searched by 'XPATH'
#
When I click on the Button '//input[@type='image'][@name='buyFlights'][@src='/images/forms/purchase.gif']' searched by 'XPATH'
Then i close the Site

