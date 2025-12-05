# Sudoku – Design Patterns

A comprehensive **Sudoku application** built in C# as an exercise in object-oriented design and classic **design patterns**.  
You can solve Sudokus, use hints, and play different variants (classic, other grid sizes, Samurai, Jigsaw).

---

## Contents

- [About the project](#about-the-project)
- [Key features](#key-features)
- [Design patterns and architecture](#design-patterns-and-architecture)
- [Project structure](#project-structure)
- [Installation & usage](#installation--usage)
- [Unit tests](#unit-tests)
- [Diagrams](#diagrams)
- [Possible extensions](#possible-extensions)
- [Credits](#credits)
- [License](#license)

---

## About the project

This project was developed as a **Design Patterns / OOP assignment**.  
The application does not only focus on solving Sudokus, but also on a **flexible and extensible structure**:

- Support for multiple Sudoku variants.  
- Clear separation of domain logic, UI, and infrastructure.  
- Code organized around reusable and recognizable design patterns.

The goal is to demonstrate how to keep a growing Sudoku application clean and maintainable, even as more variants and functionality are added.

---

## Key features

- ✅ **Multiple Sudoku formats**
  - Classic **9×9 Sudoku**
  - Sudokus with **other grid sizes** (smaller/larger boards)
  - **Samurai Sudoku**
  - **Jigsaw / Irregular Sudoku**

- 🎮 **Playable for users**
  - Solve a Sudoku directly in the application.
  - Option to use **hints / candidate numbers**.
  - Input validation (row, column, and region rules).

- 🧩 **Built with design patterns**
  - Easily add new variants or rules.
  - Clear models for board, cells, rules, etc.

- 🧪 **Unit tests**
  - Decoupled logic testable via the `Sudoku.Tests` project.
  - Tests for board validity, rule enforcement, and solving logic.

---

## Design patterns and architecture

The implementation is built around classic **design patterns** to improve extensibility and maintainability.  
Some examples of patterns commonly used in Sudoku architectures and applied in this project:

- **Factory / Abstract Factory**  
  To create different Sudoku types (classic, Samurai, Jigsaw, custom sizes).  
  Allows adding new variants without breaking existing code.

- **Strategy**  
  For various **solving strategies** or **hint algorithms**.  
  Lets you switch, e.g., between “basic” and “advanced” solving approaches without modifying the rest of the system.

- **Composite**  
  Useful for boards composed of multiple sub-boards (e.g., **Samurai Sudoku**).  
  Makes it possible to treat complex multi-board layouts as a single structure.

- **Observer / Event-driven behavior**  
  For UI updates when a cell changes.  
  Keeps model and presentation loosely coupled.

- **SOLID principles**  
  Clear separation of responsibilities (board, rules, UI, storage, etc.).  
  Easier to test and extend.

> Tip: check the class diagrams in the root folder to get a quick overview of the architecture.

---

## Project structure

Main folders and files:

- `Sudoku/`  
  The main application:
  - Domain and board models  
  - Logic for different Sudoku types  
  - UI / application entry point

- `Sudoku.Tests/`  
  Unit test project:
  - Test cases for board validation, rules, and (potential) solvers

- `Design Patterns 1.sln`  
  Visual Studio solution that includes both projects.

- Documentation & attachments in the root:
  - `NewClassDiagram.jpg` – updated class diagram  
  - `OldClassDiagram.jpg` – previous version  
  - `SequenceDiagram.jpg` – sequence diagram of major use cases  
  - `DP1_Persoonlijke_Samenvatting.pdf` – personal summary of the assignment  
  - `Rubric Design Patterns 1 2020-2021.pdf` – evaluation rubric (school assignment)  
  - `Uitleg patterns.docx` – explanation of the patterns used

---

## Installation & usage

### Requirements

- **Windows**
- **Visual Studio** (2019/2022) with .NET (classic .NET Framework)
- The GitHub repository

### Clone the repository

```bash
git clone https://github.com/ferrannl/Sudoku-Design-Patterns.git
cd Sudoku-Design-Patterns
