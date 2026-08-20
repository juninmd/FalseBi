# Contributing to FalseBi

Thank you for your interest in contributing! This document provides guidelines for development and CI/CD workflows.

## Development Setup

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Git

### Getting Started

```bash
git clone https://github.com/juninmd/FalseBi.git
cd FalseBi
dotnet restore
dotnet build
dotnet test
```

## Code Standards

### Formatting
All code must pass `dotnet format` checks before committing:

```bash
dotnet format --verify-no-changes
```

If formatting issues are found:

```bash
dotnet format
```

### Analyzers
The project uses .NET analyzers with warnings-as-errors. Fix all warnings before submitting a PR.

### Naming Conventions
- Classes: PascalCase (`DataGenerationService`)
- Methods: PascalCase (`GenerateRandomData`)
- Properties: PascalCase (`TempoMedioDia`)
- Private fields: camelCase with underscore prefix when needed

## Testing

### Running Tests

```bash
dotnet test
```

### Running Tests with Coverage

```bash
dotnet test --collect:"XPlat Code Coverage"
```

### Writing Tests
- Use xUnit as the test framework
- Name test methods using the pattern: `MethodName_Scenario_ExpectedResult`
- Use `[Theory]` with `[InlineData]` for parameterized tests
- Aim for tests that cover all business logic branches

### Coverage Requirements
- Minimum 80% code coverage for new code
- All public methods must have corresponding tests
- Edge cases and error conditions must be tested

## CI/CD Pipeline

### Pipeline Stages

The CI/CD pipeline (`.github/workflows/ci.yml`) runs on every push and PR:

1. **Lint & Format** - Verifies code formatting and analyzer rules
2. **Build** - Compiles the solution in Release configuration
3. **Test & Coverage** - Runs unit tests with coverage collection
4. **Deploy** - Publishes artifacts (main branch only)

### PR Requirements
All pull requests must pass the full CI pipeline before merging:
- Formatting check (`dotnet format --verify-no-changes`)
- Build succeeds with no warnings
- All tests pass
- No decrease in code coverage

### Branch Strategy
- `main` - Production-ready code
- `develop` - Integration branch for features
- Feature branches: `feature/description`
- Bug fixes: `fix/description`

## Commit Messages

Use clear, descriptive commit messages:
- `feat: Add new data generation method`
- `fix: Correct age mapping for value 3`
- `test: Add unit tests for DataGenerationService`
- `docs: Update README with CI badge`
- `refactor: Extract business logic from Program.cs`

## Release Process

Releases are automated via Release Drafter. When PRs are merged to `main`:
- Release notes are automatically drafted
- Semantic versioning is applied based on labels
- Create a new release from the draft to trigger deployment
