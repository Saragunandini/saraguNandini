
Feature: Login

  Scenario: Valid login
    Given I open login page
    When I enter credentials
    Then I should see dashboard
