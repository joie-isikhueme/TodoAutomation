# TodoAutomation

Browser tests for [The Internet's Add/Remove Elements page](https://the-internet.herokuapp.com/add_remove_elements/), written in C# with Microsoft Playwright and NUnit.

## What it tests

1. The page opens and its title is "The Internet".
2. Clicking "Add Element" shows a "Delete" button.
3. Clicking "Add Element" twice shows two "Delete" buttons.

## Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) (version 10.0 or later)
- [Git](https://git-scm.com/downloads), if you want to clone the repository

## Running the tests

1. Clone the repository and open the `TodoAutomation` folder.
2. Install the Playwright browsers. From the folder, run:

   ```powershell
   .\bin\Debug\net10.0\playwright.ps1 install
   ```

   Run `dotnet build` first if the `bin` folder doesn't exist yet.

3. Run the tests:

   ```powershell
   dotnet test
   ```

## Project layout

- `Pages/AddRemovePage.cs` is the page class. It stores the browser page and the page's locators, and defines the actions the tests use: opening the page, clicking Add, and finding the Delete buttons.
- `SmokeTests.cs` contains the tests. They describe what to do and what to check, without any URLs or button names.
- `TodoAutomation.csproj` is the project file that lists the packages the project needs.