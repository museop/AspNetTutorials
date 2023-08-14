Feature: Calculator Feature
    In order to perform calculations
    As a user
    I want to use the calculator service

    Scenario: Adding two numbers
        Given the calculator service is available
        When I add 5 and 7
        Then the result should be 12