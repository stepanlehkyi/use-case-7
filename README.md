
This project includes two main components: PlayerAnalyzerTests and Test, which relates to the PlayerAnalyzer and StudentConverter classes, respectively. The PlayerAnalyzerTests class contains various unit tests to validate the CalculateScore method of the PlayerAnalyzer class. These tests cover different scenarios including players of varying ages and experience, multiple players, cases where the player list is empty, and even when the skills of a player are not specified (i.e., null). These tests help ensure the PlayerAnalyzer's accuracy and reliability in score calculation under different conditions.

The Test class includes unit tests for the StudentConverter class. The tests in this class aim to validate whether the ConvertStudents method correctly identifies students who have achieved HonorRoll, Exceptional status, or have passed or failed, based on their age and grades. Furthermore, tests are designed to handle edge cases such as when the input list of students is empty or null, ensuring that the method functions as expected under all scenarios.

To run these tests locally, you need to follow these steps:

Ensure that you have .NET Core installed on your system. If you don't, you can download it from the official Microsoft website.
Navigate to the root directory of the project in your terminal or command prompt.
Use the command dotnet restore to restore all the dependencies and tools of the project.
Use the command dotnet build to build the project and its dependencies into a set of binaries. Make sure that the build is successful without any errors.
To run the tests, use the command dotnet test. This will run all the tests in the project and provide you with an output showing the tests that passed or failed.
To only run a specific test class, use the command dotnet test --filter FullyQualifiedName~Namespace.ClassName.MethodName. Replace 'Namespace', 'ClassName', and 'MethodName' with the details of the specific test you wish to run.
Review the test results in the terminal output.
