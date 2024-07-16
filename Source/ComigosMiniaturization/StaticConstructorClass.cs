using System.Collections.Generic;
using Verse;

namespace ComigosMiniaturization;

[StaticConstructorOnStartup]
public static class StaticConstructorClass
{
    static StaticConstructorClass()
    {
        // Go through all ThingDefs that are work tables
        foreach (var thingDef in DefDatabase<ThingDef>.AllDefsListForReading)
        {
            if (!thingDef.IsWorkTable)
            {
                continue;
            }

            var thingDefExtension = ThingDefExtension.Get(thingDef);

            // Sort out recipe inheritance
            if (thingDefExtension.inheritRecipesFrom == null)
            {
                continue;
            }

            var curRecipes = new List<RecipeDef>(thingDef.AllRecipes);
            NonPublicFields.ThingDef_allRecipesCached.SetValue(thingDef, null);
            foreach (var otherBench in thingDefExtension.inheritRecipesFrom)
            {
                var recipes = otherBench.AllRecipes ?? [];
                foreach (var recipe in recipes)
                {
                    if (!thingDefExtension.Allows(recipe))
                    {
                        continue;
                    }

                    if (thingDef.recipes == null)
                    {
                        thingDef.recipes = [];
                    }

                    if (!curRecipes.Contains(recipe))
                    {
                        thingDef.recipes.Add(recipe);
                    }
                }
            }
        }
    }
}