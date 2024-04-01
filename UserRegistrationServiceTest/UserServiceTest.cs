namespace UserRegistrationService.Tests;

[TestClass]
public class UserServiceTests
{
    [TestMethod]
    public void RegisterUser_ValidInput_Success() // Test method to verify successful user registration.
    {
        // Arrange
        var userService = new UserService(); // Creating an instance of the UserService.

        // Act
        var result = userService.RegisterUser("parisaaz12", "Mehrsam12!", "parisaaz@example.com"); // Invoking the RegisterUser method with valid input.

        // Assert
        Assert.AreEqual("User parisaaz12 registered successfully", result); // Asserting that the result matches the expected success message.
    }

    [TestMethod]
    public void RegisterUser_InvalidUsername_Failure() // Test method to verify failure due to an invalid username.
    {
        // Arrange
        var userService = new UserService(); // Creating an instance of the UserService.

        // Act
        var result = userService.RegisterUser("par", "Mehrsam12!", "parisaaz@example.com"); // Invoking the RegisterUser method with an invalid username.

        // Assert
        Assert.AreEqual("Invalid username", result); // Asserting that the result matches the expected error message for an invalid username.
    }

    [TestMethod]
    public void IsUsernameValid_ValidUsername_ReturnsTrue() // Test method to verify that a valid username returns true.
    {
        // Arrange
        var userService = new UserService(); // Creating an instance of the UserService.

        // Act
        var isValid = userService.IsUsernameValid("parisaaz12"); // Invoking the IsUsernameValid method with a valid username.

        // Assert
        Assert.IsTrue(isValid); // Asserting that the result is true for a valid username.
    }

    [TestMethod]
    public void IsUsernameValid_InvalidUsername_ReturnsFalse() // Test method to verify that an invalid username returns false.
    {
        // Arrange
        var userService = new UserService(); // Creating an instance of the UserService.

        // Act
        var isValid = userService.IsUsernameValid("par"); // Invoking the IsUsernameValid method with an invalid username.

        // Assert
        Assert.IsFalse(isValid); // Asserting that the result is false for an invalid username.
    }

    [TestMethod]
    public void IsPasswordValid_ValidPassword_ReturnsTrue() // Test method to verify that a valid password returns true.
    {
        // Arrange
        var userService = new UserService(); // Creating an instance of the UserService.

        // Act
        var isValid = userService.IsPasswordValid("Mehrsam12!"); // Invoking the IsPasswordValid method with a valid password.

        // Assert
        Assert.IsTrue(isValid); // Asserting that the result is true for a valid password.
    }

    [TestMethod]
    public void IsPasswordValid_InvalidPassword_ReturnsFalse() // Test method to verify that an invalid password returns false.
    {
        // Arrange
        var userService = new UserService(); // Creating an instance of the UserService.

        // Act
        var isValid = userService.IsPasswordValid("Mehrsam"); // Invoking the IsPasswordValid method with an invalid password.

        // Assert
        Assert.IsFalse(isValid); // Asserting that the result is false for an invalid password.
    }

    [TestMethod]
    public void IsEmailValid_ValidEmail_ReturnsTrue() // Test method to verify that a valid email returns true.
    {
        // Arrange
        var userService = new UserService(); // Creating an instance of the UserService.

        // Act
        var isValid = userService.IsEmailValid("parisaaz@example.com"); // Invoking the IsEmailValid method with a valid email.

        // Assert
        Assert.IsTrue(isValid); // Asserting that the result is true for a valid email.
    }

    [TestMethod]
    public void IsEmailValid_InvalidEmail_ReturnsFalse() // Test method to verify that an invalid email returns false.
    {
        // Arrange
        var userService = new UserService(); // Creating an instance of the UserService.

        // Act
        var isValid = userService.IsEmailValid("invalidemail"); // Invoking the IsEmailValid method with an invalid email.

        // Assert
        Assert.IsFalse(isValid); // Asserting that the result is false for an invalid email.
    }

    [TestMethod]
    public void IsUsernameTaken_ExistingUsername_ReturnsTrue() // Test method to verify that an existing username returns true.
    {
        // Arrange
        var userService = new UserService(); // Creating an instance of the UserService.
        userService.RegisterUser("parisaaz12", "Mehrsam12!", "parisaaz@example.com"); // Registering a user with a username.

        // Act
        var isTaken = userService.IsUsernameTaken("parisaaz12"); // Invoking the IsUsernameTaken method with an existing username.

        // Assert
        Assert.IsTrue(isTaken); // Asserting that the result is true for an existing username.
    }

    [TestMethod]
    public void IsUsernameTaken_NonExistingUsername_ReturnsFalse() // Test method to verify that a non-existing username returns false.
    {
        // Arrange
        var userService = new UserService(); // Creating an instance of the UserService.

        // Act
        var isTaken = userService.IsUsernameTaken("non_existing_user"); // Invoking the IsUsernameTaken method with a non-existing username.

        // Assert
        Assert.IsFalse(isTaken); // Asserting that the result is false for a non-existing username.
    }
}
