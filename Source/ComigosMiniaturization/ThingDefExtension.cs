using System.Collections.Generic;
using Verse;

namespace ComigosMiniaturization;

public class ThingDefExtension : DefModExtension
{
    private static readonly ThingDefExtension defaultValues = new ThingDefExtension();

    public ThingFilter allowedProductFilter;

    public List<RecipeDef> allowedRecipes;

    public ThingFilter disallowedProductFilter;

    public List<RecipeDef> disallowedRecipes;

    public List<ThingDef> inheritRecipesFrom;

    public static ThingDefExtension Get(Def def)
    {
        return def.GetModExtension<ThingDefExtension>() ?? defaultValues;
    }


    public override IEnumerable<string> ConfigErrors()
    {
        if (inheritRecipesFrom == null)
        {
            yield return "inheritRecipesFrom is null.";
        }
        else
        {
            var nonWorkbenchDefNames = new List<string>();
            foreach (var thing in inheritRecipesFrom)
            {
                if (!thing.IsWorkTable)
                {
                    nonWorkbenchDefNames.Add(thing.defName);
                }
            }

            if (nonWorkbenchDefNames.Any())
            {
                yield return
                    $"the following ThingDefs in inheritRecipesFrom are not workbenches: {nonWorkbenchDefNames.ToCommaList()}";
            }
        }
    }

    public bool Allows(RecipeDef recipe)
    {
        var producedThingDef = recipe.ProducedThingDef;
        return (producedThingDef == null ||
                (allowedProductFilter == null || allowedProductFilter.Allows(producedThingDef)) &&
                (disallowedProductFilter == null || !disallowedProductFilter.Allows(producedThingDef))) &&
               (allowedRecipes == null || allowedRecipes.Contains(recipe)) &&
               (disallowedRecipes == null || !disallowedRecipes.Contains(recipe));
    }
}