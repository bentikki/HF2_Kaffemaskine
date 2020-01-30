using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine.Classes
{
    class Recipe
    {
        private List<Ingredient> ingredients;
        private Drink recipeFor;

        public List<Ingredient> Ingredients { get { return this.ingredients; } }
        public Drink RecipeForDrink { get { return this.recipeFor; } }

        public Recipe(Drink drink, List<Ingredient> ingredients)
        {
            this.recipeFor = drink;
            this.ingredients = ingredients;
        }

    }
}
