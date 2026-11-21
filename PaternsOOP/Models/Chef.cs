using PaternsOOP.Models.Enums;

namespace PaternsOOP.Models
{
    internal class Chef
    {
        private readonly BurgerBuilder _burgerBuilder = new();
        private readonly PizzaBuilder _pizzaBuilder = new();

        public Burger CookBurger(BurgerSize burgerSize, IEnumerable<Topping> toppings, IEnumerable<ExtraTopping> extraToppings)
        {
            var burger = _burgerBuilder.SetSize(burgerSize)
                   .AddTopping(toppings)
                   .AddExtraTopping(extraToppings)
                   .GetBurger();
            Console.WriteLine($"Ответ от Chef: {burger} приготовлен!");
            return burger;
        }

        public Pizza CookPizza(PizzaType pizzaType, IEnumerable<Topping> toppings, IEnumerable<ExtraTopping> extraToppings)
        {
            var pizza = _pizzaBuilder.SetType(pizzaType)
                   .AddTopping(toppings)
                   .AddExtraTopping(extraToppings)
                   .GetPizza();
            Console.WriteLine($"Ответ от Chef: {pizza} приготовлена!");
            return pizza;
        }    
    }
}