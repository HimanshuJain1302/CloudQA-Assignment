# CloudQAShadowTests Documentation
## Project Overview
This project contains automated UI tests for the Automation Practice Form . The tests are written using C#, NUnit, and Selenium WebDriver. The primary purpose is to verify the functionality of the form, specifically the submission process and the display of input values after submission.
**Key Features:**
*   Automated UI testing using Selenium WebDriver.
*   Tests written in C# using the NUnit framework.
*   Verification of form submission and data display.
**Supported Platforms/Requirements:**
*   .NET 8.0 runtime
*   ChromeDriver (version 137.0.7151.5500 or compatible)
*   Chrome browser
## Getting Started
### Installation/Setup Instructions
1.  **Install .NET 8.0 SDK:** Download and install the .NET 8.0 SDK from the official Microsoft website.
2.  **Install a compatible Chrome Browser:** Ensure you have a compatible version of Chrome browser installed.
3.  **Clone the Repository:** Clone the project repository to your local machine.
4.  **Restore NuGet Packages:** Open the project in Visual Studio or another compatible IDE and restore the NuGet packages. This can be done by right-clicking on the solution in the Solution Explorer and selecting "Restore NuGet Packages". Alternatively, use the .NET CLI:
    ```bash
    dotnet restore
    ```
    
5.  **Configure ChromeDriver:** The project uses Selenium.WebDriver.ChromeDriver. Ensure that the ChromeDriver version is compatible with your installed Chrome browser version. NuGet should handle this automatically.
### Dependencies/Prerequisites
The project relies on the following NuGet packages:
*   **Microsoft.NET.Test.Sdk:** Provides the necessary components for running tests in .NET.
*   **NUnit:** A unit-testing framework for .NET.
*   **NUnit.Analyzers:** Provides Roslyn analyzers for NUnit.
*   **NUnit3TestAdapter:** Allows NUnit tests to be discovered and run by Visual Studio.
*   **Selenium.WebDriver:** Provides the core Selenium WebDriver functionality.
*   **Selenium.Support:** Provides support classes for Selenium WebDriver.
*   **Selenium.WebDriver.ChromeDriver:** Provides the ChromeDriver implementation for controlling Chrome.
*   **DotNetSeleniumExtras.WaitHelpers:** Provides additional wait helpers for Selenium.
*   **coverlet.collector:** Used for code coverage analysis.
These dependencies are automatically managed by NuGet.
```
## Code Structure
The project structure is as follows:
CloudQAShadowTests/
├── bin/
│   └── Debug/
│       └── net8.0/       
├── obj/
│   └── Debug/
│       └── net8.0/
├── CloudQAShadowTests.csproj
└── UnitTest1.cs
```
**Key Components:**
*   **CloudQAShadowTests.csproj:** The C# project file, which defines the project's dependencies and build configuration.
*   **UnitTest1.cs:** Contains the NUnit test class `FormFieldTests` with the test method `FullFormSubmission_ShouldDisplayInputValues`. This file includes the Selenium code to interact with the Automation Practice Form.
*   **bin/:** Contains the compiled binaries of the project.
*   **obj/:** Contains intermediate build objects.

This code performs the following actions:
1.  Navigates to the specified `baseUrl`.
2.  Locates the first name field, clears it, and enters a value.
3.  Locates the date of birth field, clears it, and enters a value.
4.  Locates the mobile number field, clears it, and enters a value.
5.  Locates the "Agree" checkbox and clicks it if it's not already selected.
6.  Locates the submit button and clicks it.
7.  Waits for 2 seconds.
8.  Retrieves the page source and asserts that it contains the entered first name, date of birth, and mobile number.
