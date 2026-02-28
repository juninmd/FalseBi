```markdown
# AGENTS.md - AI Coding Agent Guidelines

These guidelines outline the principles and rules for development of AGENTS.md, a repository for AI coding agents.  Adherence to these principles is crucial for maintaining a sustainable, efficient, and high-quality codebase.

## 1. DRY (Don't Repeat Yourself)

*   All code should have a single, well-defined purpose.
*   Avoid redundant logic, algorithms, or data structures.
*   Refactor code to eliminate duplicate functionality across multiple files.
*   When a component is reused, its purpose and implementation should be clearly documented.

## 2. KISS (Keep It Simple, Stupid)

*   Favor simple, understandable code over complex, convoluted solutions.
*   Minimize cognitive load for developers.
*   Strive for readability and maintainability.
*   Avoid unnecessary abstractions.

## 3. SOLID Principles

*   **Single Responsibility Principle:** Each class or module should have a single, focused responsibility.
*   **Open/Closed Principle:** The system should be extensible without modifying the existing code.  New functionality should be added via new classes/modules, not by modifying the core.
*   **Liskov Substitution Principle:**  Subclasses should be substitutable for their base classes without altering the correctness of the program.
*   **Interface Segregation Principle:**  Clients should not be forced to depend on methods they do not use.
*   **Dependency Inversion Principle:**  High-level modules should not depend on low-level modules; they should depend on abstractions.

## 4. YAGNI (You Aren't Gonna Need It)

*   Only implement functionality that is currently required.
*   Don't introduce features or abstractions prematurely.
*   Refactor code to remove unused components or methods.

## 5. Code Structure & Organization

*   **File Size Limit:** Each file must have a maximum of 180 lines of code.
*   **Modular Design:**  Break down large functions/modules into smaller, logical units.
*   **Clear Naming Conventions:**  Use descriptive and consistent naming conventions.
*   **Comments:**  Provide clear and concise comments to explain complex logic or decisions.  Comments should be concise and to the point.  Avoid inline comments that simply repeat code.
*   **Data Structures:**  Use appropriate data structures for optimal performance and readability.
*   **Error Handling:** Implement basic error handling where appropriate, avoiding excessive logging.
*   **Dependency Management:** Use a robust dependency management system (e.g., `pip`, `poetry`) for dependencies, ensuring versions are controlled.

## 6. Test Coverage & Development

*   **All Development Must Be Productive:**  Focus on delivering functional code.
*   **Unit Tests:**  Write comprehensive unit tests for all functions and classes.  Aim for >80% test coverage.
*   **Integration Tests:**  Create integration tests to verify interactions between different components.
*   **End-to-End Tests:**  Develop end-to-end tests to simulate real-world scenarios.
*   **Test Driven Development:**  Prioritize writing tests before writing code.
*   **Code Reviews:**  Conduct regular code reviews to identify potential issues and ensure quality.
*   **Static Analysis:** Utilize static analysis tools (e.g., pylint, flake8) to identify potential errors and code style violations.

## 7.  Specific Guidelines for AGENTS.md

*   **Data Models:** Clearly define data models within the files.
*   **Agent Interaction Protocols:** Document agent interaction protocols and data formats.
*   **Logging:** Implement a consistent logging strategy throughout the codebase.
*   **Configuration:** Design a clear and manageable configuration system.
*   **Versioning:** Implement a versioning strategy for all files and code.
*   **Documentation:**  Include concise documentation explaining key concepts and algorithms.

## 8.  Code Style & Formatting

*   Follow a consistent code style guide (e.g., PEP 8 for Python).
*   Use a code formatter (e.g., Black, yapf) to automatically enforce formatting rules.
*   Ensure consistent indentation and line spacing.
*   Use descriptive variable names.

## 9.  Continuous Improvement

*   Regularly review and update these guidelines.
*   Track code changes and their impact.
*   Establish a process for addressing identified issues.

These guidelines are intended as a starting point and may be adapted as the project evolves.  Regular review and refinement are encouraged.
```