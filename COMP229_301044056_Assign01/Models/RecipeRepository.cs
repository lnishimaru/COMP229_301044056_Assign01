using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_301044056_Assign01.Models
{
    public class RecipeRepository: IRecipeRepository
    {
        public IQueryable<Recipe> Recipes => new List<Recipe> {
                new Recipe { ID=301,Name = "Panna Cotta", Category="Desserts",Cuisine="Italian" },
                new Recipe { ID=101,Name = "Autumn Soup", Category="Appetizers",Cuisine="American" },
                new Recipe { ID=201,Name = "Beef Taco", Category="Entrees",Cuisine="Mexican"} }.AsQueryable<Recipe>();
    }
}
