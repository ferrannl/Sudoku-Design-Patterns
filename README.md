# Sudoku – Design Patterns

A complete **Sudoku application** built in C# as an exercise in object-oriented design and classic **design patterns**.  
You can solve Sudokus, use hints, and play various variants (classic, different grid sizes, Samurai, Jigsaw).

---

## Contents

- [About the project](#about-the-project)
- [Key features](#key-features)
- [Design patterns & architecture](#design-patterns--architecture)
- [Project structure](#project-structure)
- [Installation & usage](#installation--usage)
- [Unit tests](#unit-tests)
- [Diagrams](#diagrammen)
- [Possible extensions](#possible-extensions)
- [Credits](#credits)
- [License](#license)

---

## About the project

This project was developed as a **Design Patterns / OOP assignment**.  
The application focuses not only on solving Sudokus, but especially on creating a **flexible and extensible architecture**:

- Support for multiple Sudoku variants.
- Clean separation between domain logic, UI, and infrastructure.
- Code organized around reusable and recognizable design patterns.

The goal is to demonstrate how to keep a growing Sudoku application clean and maintainable, even when more variants and features are added.

---

## Key Features

- ✅ **Multiple Sudoku formats**
  - Classic **9×9 Sudoku**
  - Sudokus with **different grid sizes**
  - **Samurai Sudoku**
  - **Jigsaw / Irregular Sudoku**

- 🎮 **Fully playable**
  - Solve any Sudoku manually within the application.
  - Option to use **helper numbers / hints**.
  - Input validation (rows, columns, and blocks).

- 🧩 **Designed with patterns**
  - Easily add new variants or rules.
  - Clear models for boards, cells, rules, etc.

- 🧪 **Unit tests**
  - Decoupled logic testable via the `Sudoku.Tests` project.
  - Tests for valid/invalid boards and solving logic.

---

## Design Patterns & Architecture

The implementation uses classic **design patterns** to improve extensibility and maintainability.  
Examples of patterns used in the architecture:

- **Factory / Abstract Factory**  
  For creating different Sudoku types (classic, Samurai, Jigsaw, custom sizes) without modifying existing code.

- **Strategy**  
  For various solving strategies or hint algorithms.  
  Allows switching between basic and advanced strategies easily.

- **Composite**  
  Useful for boards consisting of multiple sub-boards (e.g., **Samurai Sudoku**).  
  Treats multiple interconnected grids as one logical board.

- **Observer / Event-driven structure**  
  For UI updates when a cell changes.  
  Keeps model and presentation loosely coupled.

- **SOLID principles**  
  Ensures clean separation of concerns and easier testing.

> Tip: Check the class diagrams in the root of the repository for a quick overview of the architecture.

---

## Project Structure

Main folders and files:

- **`Sudoku/`**  
  Main application:
  - Domain and board models  
  - Logic for different Sudoku types  
  - UI / entry point

- **`Sudoku.Tests/`**  
  Unit tests:
  - Validation tests  
  - Rule tests  
  - Solver tests

- **`Design Patterns 1.sln`**  
  Visual Studio solution including all projects.

- **Documentation in the root:**
  - `NewClassDiagram.jpg` – updated class diagram  
  - `OldClassDiagram.jpg` – older class diagram  
  - `SequenceDiagram.jpg` – sequence diagram  
  - `DP1_Persoonlijke_Samenvatting.pdf` – personal summary  
  - `Rubric Design Patterns 1 2020-2021.pdf` – assignment rubric  
  - `Uitleg patterns.docx` – explanation of the patterns used

---

## Installation & Usage

### Requirements

- **Windows**
- **Visual Studio 2019/2022** with .NET Framework support
- Git (optional)

### Clone the repository

```bash
git clone https://github.com/ferrannl/Sudoku-Design-Patterns.git
cd Sudoku-Design-Patterns

Open the solution in Visual Studio and run the main project.


---

Unit Tests

The Sudoku.Tests project includes tests for:

Board validation

Rule compliance

Solver behavior

Edge cases for custom Sudoku variants


All tests can be run via the Visual Studio Test Explorer.


---

Diagrams

The repository includes:

Class diagrams

Sequence diagrams

Pattern explanations


These illustrate how the architecture is structured and how Sudoku objects interact.


---

Possible Extensions

Ideas for future work:

Add more solving strategies

Add difficulty estimation

Add a GUI framework such as WPF or MAUI

Add a puzzle generator

Add more Sudoku variants (Killer, Hyper, Thermo, etc.)



---

Credits

Developed as part of a Design Patterns / OOP course assignment.


---

License

This project is provided for educational purposes.
Feel free to fork, modify, or use it as a reference.
