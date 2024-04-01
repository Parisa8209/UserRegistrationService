# UserRegistrationService
• Challenges faced and how you overcame them
Implementing validation logic for usernames, passwords, and emails posed a challenge due to the  different necessities.However, breaking down each validation rule into separate methods helped in overseeing complexity and guaranteeing testability. 
Setting up test cases for edge cases and invalid inputs required careful consideration to cover all scenarios. However by designing specific test methods for each validation rule and registration process, comprehensive test coverage was achieved.
• What you learned from using TDD for this project
Writing tests before implementing functionality helped in identifying potential bugs and design flaws early in the development process. As a result, issues were addressed promptly, reducing the likelihood of critical bugs in the final product.
• Any considerations or assumptions made during development
The current implementation assumes a relatively small number of users due to storing user data in memory. For larger-scale applications, considerations such as database integration would be necessary to ensure scalability and data persistence.
