# NUnit Hands-On

## Objective

Implement Unit Testing using the NUnit framework and validate the Addition functionality of the SimpleCalculator class.

## Concepts Covered

* Unit Testing
* Automated Testing
* NUnit Framework
* TestFixture
* SetUp
* TearDown
* TestCase
* Assertions

## Tested Method

Addition(double a, double b)

## NUnit Attributes Used

### TestFixture

Identifies the class containing test cases.

### SetUp

Runs before each test case execution.

### TearDown

Runs after each test case execution.

### TestCase

Provides multiple input values for testing.

## Assertion Used

Assert.That(actual, Is.EqualTo(expected));

## Test Cases

| Input A | Input B | Expected Result |
| ------- | ------- | --------------- |
| 10      | 20      | 30              |
| 5       | 5       | 10              |
| 100     | 200     | 300             |
| -10     | 20      | 10              |

## Expected Result

All test cases should pass successfully.

## Conclusion

Unit testing helps verify individual units of code independently, improves software quality, and enables automated validation of application functionality.

## Author

Dhanu

