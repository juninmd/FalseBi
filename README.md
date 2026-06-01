# FalseBi

![CI/CD Pipeline](https://github.com/juninmd/FalseBi/actions/workflows/ci.yml/badge.svg)

**A standard software project.**

**Description:**

This repository contains a standard software project that generates random Netflix data and displays tables of categories, countries, videos, and age ranges.

**Installation:**

1.  Clone the repository: `git clone [repository_url]`
2.  Navigate to the project directory: `cd FalseBi`
3.  Install .NET 6.0 SDK (https://dotnet.microsoft.com/download/dotnet/6.0)
4.  Restore dependencies: `dotnet restore`

**Usage:**

*   **Console:**  `dotnet run --project FalseBI.Console/FalseBI.ConsoleApp.csproj` will launch the console interface.
*   **Design:**  Use the `FalseBI.sln` file to view the design and interact with the 3D model.
*   **Code:**  The `FalseBI.Console` contains source code for various functionalities.  Examine the relevant files for details.
*   **Testing:**  Run tests with `dotnet test`

**CI/CD:**

This project uses GitHub Actions for continuous integration and deployment.
The workflow includes linting, testing, building, and deployment stages.
See `.github/workflows/ci.yml` for details.

**Contributing:**

Please read [CONTRIBUTING.md](CONTRIBUTING.md) for details on our code of conduct and the process for submitting pull requests.

**License:**

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
