using PaternsOOP.Models.Enums;
using PaternsOOP.Models.Interfaces;

namespace PaternsOOP.Models
{
    internal class Chef
    {
        private readonly BurgerBuilder _burgerBuilder = new();
        private readonly PizzaBuilder _pizzaBuilder = new();

        public Burger CookBigBurger(IEnumerable<Topping> toppings, IEnumerable<ExtraTopping> extraToppings) => 
            CookBurger(BurgerSize.Большой, toppings, extraToppings);

        public Burger CookSmallBurger(IEnumerable<Topping> toppings, IEnumerable<ExtraTopping> extraToppings) =>
            CookBurger(BurgerSize.Маленький, toppings, extraToppings);

        public Pizza CookPizza(PizzaType pizzaType, IEnumerable<Topping> toppings, IEnumerable<ExtraTopping> extraToppings)
        {
            var pizza = _pizzaBuilder.SetType(pizzaType)
                   .AddTopping(toppings)
                   .AddExtraTopping(extraToppings)
                   .GetPizza();
            PrintStatuses(_pizzaBuilder.ToString(), pizza.ToString());
            return pizza;
        }

        private static void PrintStatuses(string builder, string chef)
        {
            Console.WriteLine($"Ответ от Builder : {builder}");
            Console.WriteLine($"Ответ от Шефа : {chef}, приготовлен!");
        }

        private Burger CookBurger(BurgerSize burgerSize, IEnumerable<Topping> toppings, IEnumerable<ExtraTopping> extraToppings)
        {
            var burger = _burgerBuilder.SetSize(burgerSize)
                   .AddTopping(toppings)
                   .AddExtraTopping(extraToppings)
                   .GetBurger();
            PrintStatuses(_burgerBuilder.ToString(), burger.ToString());
            return burger;
        }
    }
}