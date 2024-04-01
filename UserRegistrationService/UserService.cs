using System.Text.RegularExpressions;

namespace UserRegistrationService;

public class UserService
{
    private readonly List<User> _users; // Declaring a private field to store user data.

    public UserService()
    {
        _users = new List<User>(); // Initializing the list of users.
    }
    //Regestering new Users 
    public string RegisterUser(string username, string password, string email) // Method for registering new users.
    {
        if (!IsUsernameValid(username)) // Checking if the username is valid.
            return "Invalid username"; // Returning an error message if the username is invalid.

        if (!IsPasswordValid(password)) // Checking if the password is valid.
            return "Invalid password"; // Returning an error message if the password is invalid.

        if (!IsEmailValid(email)) // Checking if the email is valid.
            return "Invalid email"; // Returning an error message if the email is invalid.

        if (IsUsernameTaken(username)) // Checking if the username is already taken.
            return "Username already taken"; // Returning an error message if the username is already taken.

        var user = new User // Creating a new user object.
        {
            Username = username,
            Password = password,
            Email = email
        };

        _users.Add(user); // Adding the new user to the list of users.

        return $"User {username} registered successfully"; // Returning a success message after registering the user.
    }
    //Ensuring Data Validation

    public bool IsUsernameValid(string username) // Method for validating the username.
    {
        return !string.IsNullOrEmpty(username) && username.Length >= 5 && username.Length <= 20 && Regex.IsMatch(username, "^[a-zA-Z0-9]+$"); // Checking if the username is not empty, its length is between 5 and 20 characters, and it consists only of alphanumeric characters.
    }

    public bool IsPasswordValid(string password) // Method for validating the password.
    {
        return !string.IsNullOrEmpty(password) && password.Length >= 8 && Regex.IsMatch(password, @"^(?=.*[^\w\s]).{8,}$"); // Checking if the password is not empty, its length is at least 8 characters, and it contains at least one special character.
    }

    public bool IsEmailValid(string email) // Method for validating the email.
    {
        return !string.IsNullOrEmpty(email) && Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"); // Checking if the email is not empty and matches the format of a valid email address.
    }

    //Uniqueness of Usernames

    public bool IsUsernameTaken(string username) // Method for checking if the username is already taken.
    {
        return _users.Any(u => u.Username == username); // Checking if any user in the list has the same username.
    }
}
