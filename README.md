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
- [Diagrams](#diagrams)
- [Possible extensions](#possible-extensions)
- [Credits](#credits)
- [License](#license)

---

## About the project

This project was developed as a **Design Patterns / OOP assignment**.  
The application focuses on building a **flexible and extensible architecture**:

- Support for multiple Sudoku variants.
- Clean separation between domain logic, UI, and infrastructure.
- Code structured with reusable and recognizable design patterns.

The goal is to demonstrate how to keep a growing Sudoku application clean and maintainable, even as more variants and features are added.

---

## Key Features

- ✅ **Multiple Sudoku formats**
  - Classic **9×9 Sudoku**
  - Custom grid sizes
  - **Samurai Sudoku**
  - **Jigsaw / Irregular Sudoku**

- 🎮 **Fully playable**
  - Solve Sudokus manually inside the application.
  - Optional **helper numbers / hints**.
  - Input validation (rows, columns, and blocks).

- 🧩 **Designed with patterns**
  - Easily add new rules or Sudoku variants.
  - Clean object models for boards, cells, constraints, etc.

- 🧪 **Unit tests**
  - Tests included in the `Sudoku.Tests` project.
  - Covers board validation and solving logic.

---

## Design Patterns & Architecture

Patterns used in this project include:

### **Factory / Abstract Factory**
To create different Sudoku types without modifying existing code.

### **Strategy**
For swapping solving strategies or hint algorithms.

### **Composite**
Perfect for multi-board structures like **Samurai Sudoku**.

### **Observer**
Used for UI updates when cells change.

### **SOLID principles**
Ensures maintainable and testable code.

> See the diagrams below for a visual overview of the system architecture.

---

## Project Structure

Sudoku/

Domain models

Sudoku types

UI / Program entry point


Sudoku.Tests/

Unit tests for logic and solver


Design Patterns 1.sln

Documentation in the repository root:

- `NewClassDiagram.jpg`
- `OldClassDiagram.jpg`
- `SequenceDiagram.jpg`
- `DP1_Persoonlijke_Samenvatting.pdf`
- `Rubric Design Patterns 1 2020-2021.pdf`
- `Uitleg patterns.docx`

---

## Installation & Usage

### Requirements

- Windows  
- Visual Studio 2019/2022  
- .NET Framework support  

### Clone the repository

```bash
git clone https://github.com/ferrannl/Sudoku-Design-Patterns.git
cd Sudoku-Design-Patterns

Open the solution in Visual Studio and run the project.


---

Unit Tests

Run all tests via Test Explorer in Visual Studio.

The tests cover:

Board validation

Rules & constraints

Solver behavior

Edge cases for custom Sudoku variants



---

📊 Diagrams

Below are the architectural diagrams included in this repository:


---

🆕 Updated Class Diagram

<img src="./NewClassDiagram.jpg" alt="New Class Diagram" width="700"/>
---

🏛️ Old Class Diagram

<img src="./OldClassDiagram.jpg" alt="Old Class Diagram" width="700"/>
---

🔁 Sequence Diagram

<img src="./SequenceDiagram.jpg" alt="Sequence Diagram" width="700"/>
---

Possible Extensions

Ideas for future improvements:

More solving strategies

Difficulty estimation

Puzzle generator

GUI framework (WPF, MAUI, Avalonia)

Additional Sudoku variants (Killer, Thermo, Hyper, etc.)



---

Credits

Created as part of a Design Patterns / OOP course assignment.


---

License

This project is provided for educational purposes.
Feel free to fork or modify it.
