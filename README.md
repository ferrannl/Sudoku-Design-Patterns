# Sudoku – Design Patterns

Een uitgebreide **Sudoku-applicatie** gebouwd in C# als oefening in objectgeoriënteerd design en klassiekere **design patterns**.  
Je kunt zelf Sudoku’s oplossen, hints gebruiken en verschillende varianten spelen (klassiek, andere formaten, Samurai, Jigsaw).

---

## Inhoud

- [Over het project](#over-het-project)
- [Belangrijkste features](#belangrijkste-features)
- [Design patterns en architectuur](#design-patterns-en-architectuur)
- [Projectstructuur](#projectstructuur)
- [Installatie & gebruik](#installatie--gebruik)
- [Unit tests](#unit-tests)
- [Diagrammen](#diagrammen)
- [Mogelijke uitbreidingen](#mogelijke-uitbreidingen)
- [Credits](#credits)
- [Licentie](#licentie)

---

## Over het project

Dit project is ontwikkeld als **Design Patterns / OOP-opdracht**.  
De applicatie focust niet alleen op het oplossen van Sudoku’s, maar vooral op een **flexibele en uitbreidbare structuur**:

- Ondersteuning voor meerdere Sudoku-varianten.
- Duidelijk gescheiden domeinlogica, UI en infrastructuur.
- Code georganiseerd rond herbruikbare en herkenbare design patterns.

Het doel is om te laten zien hoe je een groeiende Sudoku-app netjes kunt houden, ook als er meer varianten en functionaliteit bijkomen.

---

## Belangrijkste features

- ✅ **Meerdere Sudoku-formaten**
  - Klassieke **9×9 Sudoku**
  - Sudoku’s met **andere formaten** (bijv. kleinere/gr grotere roosters)
  - **Samurai Sudoku**
  - **Jigsaw / Irregular Sudoku**

- 🎮 **Speelbaar voor gebruikers**
  - Los zelf een Sudoku op in de applicatie.
  - Mogelijkheid om **hulpgetallen / hints** te gebruiken.
  - Validatie van invoer (rij, kolom en blokregels).

- 🧩 **Ontworpen met design patterns**
  - Flexibel toevoegen van nieuwe varianten of regels.
  - Duidelijke modellen voor bord, vakjes, regels, etc.

- 🧪 **Unit tests**
  - Losgekoppelde logica die via het project `Sudoku.Tests` getest kan worden.
  - Tests voor o.a. geldige/ongeldige borden en oplossingslogica.

---

## Design patterns en architectuur

De implementatie is rondom klassieke **design patterns** opgebouwd om uitbreidbaarheid en onderhoudbaarheid te verbeteren.  
Enkele voorbeelden van patronen die in dit soort Sudoku-architecturen passen en waar dit project op leunt:

- **Factory / Abstract Factory**
  - Voor het aanmaken van verschillende Sudoku-typen (klassiek, Samurai, Jigsaw, andere groottes).
  - Maakt het eenvoudig om nieuwe varianten toe te voegen zonder bestaande code te breken.

- **Strategy**
  - Voor verschillende **oplosstrategieën** of **hint-algoritmes**.
  - Laat toe om bijvoorbeeld een “basic” en een “advanced” strategie te wisselen zonder de rest van de code aan te passen.

- **Composite**
  - Bruikbaar voor borden die bestaan uit meerdere deelborden (zoals **Samurai Sudoku**).
  - Maakt het mogelijk om borden als één geheel te behandelen, ook al bestaan ze intern uit meerdere gekoppelde roosters.

- **Observer / Event-achtig gedrag**
  - Voor UI-updates wanneer een vakje verandert.
  - Laat model en presentatie losjes gekoppeld samenwerken.

- **SOLID-principes**
  - Scheiding van verantwoordelijkheden (bord, regels, UI, opslag, etc.).
  - Makkelijker testen en uitbreiden.

> Tip: bekijk de klassediagrammen in de root van de repository om de architectuur snel te overzien.

---

## Projectstructuur

Hoofdmappen en bestanden:

- `Sudoku/`  
  De hoofdapplicatie:
  - Domein- en bordmodellen.
  - Logica voor verschillende Sudoku-typen.
  - UI / entry point van de applicatie.

- `Sudoku.Tests/`  
  Unit-testproject:
  - Testcases voor bordvalidatie, regels en (mogelijk) oplossers.

- `Design Patterns 1.sln`  
  Visual Studio-oplossing die beide projecten bundelt.

- Documentatie & bijlagen in de root:
  - `NewClassDiagram.jpg` – bijgewerkt klassediagram.
  - `OldClassDiagram.jpg` – oudere versie van het klassediagram.
  - `SequenceDiagram.jpg` – sequencediagram van belangrijke use-cases.
  - `DP1_Persoonlijke_Samenvatting.pdf` – persoonlijke samenvatting van de opdracht.
  - `Rubric Design Patterns 1 2020-2021.pdf` – beoordelingsrubric (schoolopdracht).
  - `Uitleg patterns.docx` – uitleg van de gebruikte patronen.

---

## Installatie & gebruik

### Vereisten

- **Windows**
- **Visual Studio** (bijv. 2019/2022) met ondersteuning voor .NET (klassieke .NET Framework-omgeving).
- De repository van GitHub.

### Repository clonen

```bash
git clone https://github.com/ferrannl/Sudoku-Design-Patterns.git
cd Sudoku-Design-Patterns
