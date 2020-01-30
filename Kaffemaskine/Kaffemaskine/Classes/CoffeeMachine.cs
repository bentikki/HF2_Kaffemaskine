using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine.Classes
{
    class CoffeeMachine
    {
        private List<Ingredient> ingredients = new List<Ingredient>();
        private List<Recipe> recipes = new List<Recipe>();

        public List<Ingredient> Ingredients { get { return this.ingredients; } }
        public List<Recipe> Recipes { get { return this.recipes; } }

        public CoffeeMachine()
        {
            AddIngridient(new Water(5));
            AddIngridient(new Milk(2));

            AddRecipe(new Recipe(new RegularCoffee(), new List<Ingredient> { new CoffeeBeans(1), new Water(4) }));
            AddRecipe(new Recipe(new CoffeeWithMilk(), new List<Ingredient> { new CoffeeBeans(1), new Water(3), new Milk(1) }));
            AddRecipe(new Recipe(new Espresso(), new List<Ingredient> { new EspressoBeans(2), new Water(2) }));
            AddRecipe(new Recipe(new Cappucino(), new List<Ingredient> { new EspressoBeans(2), new Water(2), new Milk(2) }));
            AddRecipe(new Recipe(new Tea(), new List<Ingredient> { new GreenTea(1), new Water(4) }));
        }
        public void AddIngridient(Ingredient ingredient)
        {
            this.ingredients.Add(ingredient);
        }
        public void AddRecipe(Recipe recipe)
        {
            this.recipes.Add(recipe);
        }

        public Drink GetDrink(Drink drink)
        {   
            Recipe recipe = this.Recipes.Where(x => x.RecipeForDrink.Name == drink.Name).First();
            bool neededIngredients = true;
            List<Ingredient> usedIngridients = new List<Ingredient>();
            foreach (Ingredient ingridient in recipe.Ingredients)
            {
                if (this.ingredients.Any(ing => ing.Name == ingridient.Name))
                {
                    usedIngridients.Add(ingridient);
                }
                else
                {
                    neededIngredients = false;
                }
            }

            if (neededIngredients)
            {
                this.ingredients = this.ingredients.Except(usedIngridients).ToList();
                return drink;
            }else
            {
                throw new Exception();
            }
        }

    }
}
