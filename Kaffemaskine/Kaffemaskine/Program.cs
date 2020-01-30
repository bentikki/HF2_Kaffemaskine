using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kaffemaskine.Classes;

namespace Kaffemaskine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize the machine.
            CoffeeMachine machine = new CoffeeMachine();


            do
            {
                Console.WriteLine("Ingridients in machine:");
                Console.WriteLine("______________________");
                Console.WriteLine();
                foreach (Ingredient item in machine.Ingredients)
                {
                    Console.WriteLine("----{0} of {1}", item.Amount, item.Name);
                }
                Console.WriteLine("______________________");
                Console.WriteLine();

                Console.WriteLine("Availabe drinks in machine:");
                Console.WriteLine("______________________");
                Console.WriteLine();
                foreach (Recipe recipe in machine.Recipes)
                {
                    Console.WriteLine("----Recipe for: " + recipe.RecipeForDrink.Name);
                    foreach (Ingredient item in recipe.Ingredients)
                    {
                        Console.WriteLine("------{0} of {1}", item.Amount, item.Name);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("______________________");
                Console.WriteLine();
                Console.WriteLine("Options:");
                Console.WriteLine();
                Console.WriteLine("1. Add ingridients");
                Console.WriteLine("2. Get Drink");


                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":

                        Console.Clear();
                        Console.WriteLine("Add ingridients:");
                        Console.WriteLine();
                        Console.WriteLine("1. Coffee beans");
                        Console.WriteLine("2. Espresso beans");
                        Console.WriteLine("3. Water");
                        Console.WriteLine("4. Milk");
                        Console.WriteLine("5. Green tea leafs");

                        userChoice = Console.ReadLine();

                        switch (userChoice)
                        {
                            case "1":
                                machine.AddIngridient(new CoffeeBeans(1));
                                break;
                            case "2":
                                machine.AddIngridient(new EspressoBeans(1));
                                break;
                            case "3":
                                machine.AddIngridient(new Water(1));
                                break;
                            case "4":
                                machine.AddIngridient(new Milk(1));
                                break;
                            case "5":
                                machine.AddIngridient(new GreenTea(1));
                                break;
                            default:
                                break;
                        }

                        break;
                    case "2":

                        Console.Clear();
                        Console.WriteLine("Get Drink:");
                        Console.WriteLine();
                        Console.WriteLine("1. Regular Coffee");
                        Console.WriteLine("2. Espresso");
                        Console.WriteLine("3. Tea");


                        bool restartMenu = false;
                        try
                        {
                            userChoice = Console.ReadLine();
                            Drink chosenDrink;
                            do
                            {

                                switch (userChoice)
                                {
                                    case "1":
                                        chosenDrink = machine.GetDrink(new RegularCoffee());
                                        Console.WriteLine("Enjoy your " + chosenDrink.Name + "!");
                                        Console.ReadKey();
                                        break;
                                    case "2":
                                        chosenDrink = machine.GetDrink(new Espresso());
                                        Console.WriteLine("Enjoy your " + chosenDrink.Name + "!");
                                        Console.ReadKey();
                                        break;
                                    case "3":
                                        chosenDrink = machine.GetDrink(new Tea());
                                        Console.WriteLine("Enjoy your " + chosenDrink.Name + "!");
                                        Console.ReadKey();
                                        break;
                                    default:
                                        restartMenu = true;
                                        break;
                                }

                            } while (restartMenu);

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ingridients missing!");
                            Console.ReadKey();
                            restartMenu = true;
                        }


                        break;
                    default:
                        break;
                }



                


            } while (true);
            

            Console.ReadKey();
        }
    }
}
