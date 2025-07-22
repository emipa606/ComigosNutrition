# GitHub Copilot Instructions for ComigosMiniaturization RimWorld Mod

## Mod Overview and Purpose
The ComigosMiniaturization mod aims to enhance the RimWorld experience by introducing the ability to miniaturize various in-game objects, thus enhancing portability and flexibility in building management. This mod extends the game's functionality to allow players to move or store objects that were previously immobile, creating new opportunities for base layout optimization and resource management.

## Key Features and Systems
- **Miniaturization Mechanics**: Allows specific objects to be packed and moved within the game environment, enabling versatile base construction and redesign.
- **Custom Extensions**: Utilizes custom C# classes and XML configurations to define which objects can be miniaturized and under what conditions.
- **Recipe Integrations**: Includes specific recipes that interact with the miniaturization process, creating a seamless integration into the game's existing crafting and construction systems.

## Coding Patterns and Conventions
In this mod, the following coding patterns and conventions are employed:
- **Static Classes**: Static classes like `NonPublicFields` and `StaticConstructorClass` are used to hold utility functions and perform initializations that don't need to instantiate objects.
- **DefModExtension**: Utilizes the `DefModExtension` pattern for extending functionality in a modular and maintainable way, as evident in `ThingDefExtension`.
- **Consistent Naming**: Adopts clear and consistent naming for classes and methods to facilitate ease of understanding and readability.

## XML Integration
This mod relies on XML definitions to specify the miniaturization properties for each eligible game object:
- **ThingDefs**: XML files define objects that can be miniaturized, including any special conditions or restrictions.
- **RecipeDefs**: Additional recipes are added via XML to allow crafting items that enable or enhance miniaturization.

## Harmony Patching
Harmony is used as an advanced C# library to modify RimWorld's core game mechanics without altering the game's source code. It allows for:
- **Injection of Custom Logic**: By applying patches to specific methods, the mod can introduce new behaviors or alter existing ones integral to the miniaturization process.
- **Non-invasive Modifications**: Ensures compatibility with other mods by avoiding direct alterations to core files.

## Suggestions for Copilot
To maximize the effectiveness of GitHub Copilot, consider the following suggestions:
- **Example Requests**: Ask Copilot to generate examples of XML configurations for `ThingDef` or `RecipeDef` that are compatible with the miniaturization system.
- **Harmony Patch Suggestions**: Use Copilot to explore potential targets for Harmony patches and generate initial patching logic.
- **Code Refactoring**: Leverage Copilot to suggest refactoring opportunities in C# code, ensuring adherence to best coding practices.
- **Documentation Assistance**: Copilot can assist in generating detailed comments and documentation to enhance code readability and maintainability.

By following these guidelines and utilizing Copilot effectively, contributors and developers can efficiently expand and maintain the ComigosMiniaturization mod.
