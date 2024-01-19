Feature: Pizza Management

  Scenario: Add a pizza to the list
    Given the pizza management system is initialized
    When a pizza with name "Margherita", size 12, and price 10.99 is added
    Then the list of pizzas should contain the added pizza

  