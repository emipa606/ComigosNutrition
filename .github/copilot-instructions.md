# GitHub Copilot Instructions for Comigo's Nutrition (Continued) Mod

## Mod Overview and Purpose

Comigo's Nutrition (Continued) is a RimWorld mod that adds smaller, more efficient cooking sites and paste dispensers, ideal for spaceships and small bases. It includes a new research tab and doesn't simply replace the existing benches; instead, it adds new ones that are locked under separate research projects. These research projects are relatively cheap but required for each new bench. The mod also includes a Chinese translation by MZM_GOW and is compatible with everything as it is a purely XML and graphical mod.

## Key Features and Systems

### New Buildings

- **Smaller Electric Stove**: Requires "Compact cooking stoves" research, which requires electricity. Cooks all vanilla recipes without penalties.
- **Smaller Butcher Table**: Requires "Smaller butcher table" research, which requires smithing. Allows butchering animals and humanlikes and making kibble with 75% work speed.
- **Cutting Board**: Requires "Cutting board" research. Lightweight and more effective than a plain butcher spot but has a 65% work speed and 90% efficiency.
- **Portable Chemfuel Stove**: Requires "Portable chemfuel stove" research. Alternative to a fueled stove that can be transported easily and cooks simple and fine meals.
- **Smaller Brewery**: Requires "Small brewery" research, which requires beer brewing research. Allows making wort for beer with 75% work speed.
- **Compact Nutrient Paste Dispenser**: Requires "Compact paste dispenser" research, which requires microelectronics and regular paste dispenser research. A smaller version of a paste dispenser, just 2x2 cells in size.

### Research Unlocks

The research unlocks two variants of improved designs in two different directions:

- **In-Wall Nutrient Paste Dispenser**: Requires "In-wall dispensers" research, which requires "Compact paste dispenser" research. Just 1x1 cell size but requires 8 ingredients per meal, uses less power (75W), and can be built en masse.
- **Advanced Nutrient Paste Dispenser**: Requires "Advanced paste dispensers" research, which requires "Compact paste dispenser" research. Smaller than its vanilla version (3x3 cells) but more efficient in ingredient consumption, taking just 5 ingredients per meal, and requires 1200W to operate.
- **Nutrient Archodispenser**: An ancient artifact that can only be found as rewards to quests or, very rarely, as trader's goods. Connects to your power net, drains 3600W, and creates nutrient paste meals the most efficient way: just 4 ingredients for each glop.

## Coding Patterns and Conventions

- Use meaningful and descriptive names for variables, methods, and classes.
- Follow the RimWorld coding conventions and patterns.
- Ensure that the code is well-organized and easy to read and maintain.
- Use comments to explain complex code and to make the code more understandable.

## XML Integration

- Use XML to define new buildings and research projects.
- Ensure that the XML files are well-structured and easy to read and maintain.
- Use XML comments to explain complex XML and to make the XML more understandable.

## Harmony Patching

- Use Harmony patching to modify vanilla code and add new functionality.
- Ensure that the Harmony patches are well-organized and easy to read and maintain.
- Use Harmony comments to explain complex Harmony patches and to make the Harmony patches more understandable.

## Suggestions for Copilot

- Use Copilot to generate code snippets and complete code.
- Use Copilot to generate XML snippets and complete XML.
- Use Copilot to generate Harmony patch snippets and complete Harmony patches.
- Use Copilot to generate comments and documentation.
- Use Copilot to generate unit tests and integration tests.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

