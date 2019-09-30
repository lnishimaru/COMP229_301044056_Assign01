using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_301044056_Assign01.Models
{
    public class RecipeRepository
    {
        private static RecipeRepository tempRepository = new RecipeRepository();
        private Dictionary<string, Recipe> recipes = new Dictionary<string, Recipe>();
        public static RecipeRepository TempRepository => tempRepository;

        public RecipeRepository()
        {
            var initialItems = new[] {
            new Recipe { ID=501,Name = "Chocolate Cupcake", Category="Desserts",Cuisine="American" },
            new Recipe { ID=201,Name = "Pancakes", Category="Breakfast",Cuisine="American" },
            new Recipe { ID=101,Name = "Onion Soup", Category="Appetizers",Cuisine="French"  },
            new Recipe { ID=301,Name = "Eggplant Parmesan", Category="Entrees",Cuisine="Italian"  }
            };
            foreach (var r in initialItems)
            {
                AddRecipe(r);
            }
        }
        public IEnumerable<Recipe> Recipes => recipes.Values;
        public void AddRecipe(Recipe r) => recipes.Add(r.Name, r);
    }
}
