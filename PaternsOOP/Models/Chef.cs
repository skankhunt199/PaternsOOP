using PaternsOOP.Models.Enums;
using PaternsOOP.Models.Interfaces;

namespace PaternsOOP.Models
{
    internal class Chef
    {
        private readonly BurgerBuilder _burgerBuilder = new();
        private readonly PizzaBuilder _pizzaBuilder = new();

        public Burger CookBigBurger(IEnumerable<Topping> toppings, IEnumerable<ExtraTopping> extraToppings)
        {
           var bb = _burgerBuilder.SetSize(BurgerSize.Большой)
                   .AddTopping(toppings)
                   .AddExtraTopping(extraToppings)
                   .GetBurger();
            Console.WriteLine($"Ответ от Builder : {_burgerBuilder}");
            Console.WriteLine($"Ответ от Шефа : {bb}, приготовлен!");
            return bb;
        }
        public Burger CookSmallBurger(IEnumerable<Topping> toppings, IEnumerable<ExtraTopping> extraToppings)
        {
            var bb = _burgerBuilder.SetSize(BurgerSize.Маленький)
                   .AddTopping(toppings)
                   .AddExtraTopping(extraToppings)
                   .GetBurger();
            Console.WriteLine($"Ответ от Builder : {_burgerBuilder}");
            Console.WriteLine($"Ответ от Шефа : {bb}, приготовлен!");
            return bb;
        }
        public Pizza CookPizza(PizzaType pizzaType, IEnumerable<Topping> toppings, IEnumerable<ExtraTopping> extraToppings)
        {
            var pb = _pizzaBuilder.SetType(pizzaType)
                   .AddTopping(toppings)
                   .AddExtraTopping(extraToppings)
                   .GetPizza();
            Console.WriteLine($"Ответ от Builder : {_pizzaBuilder}");
            Console.WriteLine($"Ответ от Шефа : {pb}, приготовлена!");
            return pb;
        }
    }
}