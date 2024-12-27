**Create a new project**

Install .NET SDK 7.0 or a latest version

```sh
dotnet new nunit -n PlaywrightAutomation
cd PlaywrightAutomation
```
**Install Playwright and Other Necessary Packages**

```sh
dotnet add package Microsoft.Playwright
dotnet add package NUnit
dotnet add package NUnit3TestAdapter
dotnet add package Microsoft.NET.Test.Sdk
```
**Install Playwright browser**

playwright install


**Create folder and files in below structure**


```sh
/PlaywrightAutomation
│
├── /Pages                # Page Object Model classes (UI)
│   └── HomePage.cs       # Example page class
├── /Tests                # Test cases (UI and API)
│   ├── HomePageTests.cs  # UI tests
│   └── ApiTests.cs       # API tests
├── /Drivers              # Playwright WebDriver configurations
│   └── PlaywrightDriver.cs
├── /Reports              # Test reports and logs
├── /Utils                # Utilities like assertions, helper functions
│   ├── CustomAssertions.cs
│   └── ApiClient.cs      # Helper class for API requests
├── PlaywrightAutomation.csproj
└── /appsettings.json     # Configuration (Optional)

```

**Execute single test case**
```sh
dotnet test --filter "TestName=ValidateTitleTest"
```

**Execute all test case**

```sh
dotnet test
```
