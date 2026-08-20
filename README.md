# FalseBi

[![CI/CD Pipeline](https://github.com/juninmd/FalseBi/actions/workflows/ci.yml/badge.svg)](https://github.com/juninmd/FalseBi/actions/workflows/ci.yml)

A .NET console application that generates random Netflix BI data for analysis and reporting.

## Features

- Generate random Netflix viewing data with configurable record counts
- Export data to CSV format
- Reference tables for data categories (age, genre, country, video, viewing time)

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later

## Installation

```bash
git clone https://github.com/juninmd/FalseBi.git
cd FalseBi
dotnet restore
```

## Build

```bash
dotnet build
```

## Run

```bash
dotnet run --project FalseBI.Console
```

## Test

```bash
dotnet test
```

## CI/CD Pipeline

The project uses GitHub Actions for continuous integration and deployment. The pipeline includes:

### Quality Gates
- **Lint & Format**: Code formatting verification with `dotnet format` and Roslyn analyzers
- **Build**: Compilation in Release configuration
- **Test**: Unit tests with code coverage collection (xUnit + Coverlet)
- **Deploy**: Artifact publishing on main branch pushes

### Pipeline Triggers
- `push` to `main` or `develop` branches
- `pull_request` targeting `main`
- Manual trigger via `workflow_dispatch`

### Artifacts
- Build output (5-day retention)
- Test coverage reports (14-day retention)
- Release artifacts (30-day retention)

## Project Structure

```
FalseBi/
├── FalseBI.Console/          # Main console application
│   ├── Program.cs            # Entry point and menu logic
│   ├── DataGenerationService.cs  # Testable business logic
│   └── EntidadeNetflix.cs    # Data model
├── FalseBI.Tests/            # Unit tests
│   ├── DataGenerationServiceTests.cs
│   └── EntidadeNetflixTests.cs
└── .github/workflows/        # CI/CD pipelines
    └── ci.yml
```

## Data Model

| Field | Description | Values |
|-------|-------------|--------|
| Idade | User age | 18, 25, 30, 50 |
| IdCategoria | Genre | 1=Humor, 2=Drama, 3=Romance, 4=Action |
| IdPais | Country | 1=Brazil, 2=France, 3=Spain, 4=Cuba |
| IdVideo | Video | 1=HIMYM, 2=House, 3=Chuck, 4=Naruto |
| TempoMedioDia | Avg. daily viewing time (min) | 20, 40, 60, 120 |

## Contributing

See [CONTRIBUTING.md](CONTRIBUTING.md) for development guidelines and CI/CD workflow details.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
