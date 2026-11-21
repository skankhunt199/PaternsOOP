using PaternsOOP.Models.Enums;
using PaternsOOP.Models.Interfaces;

namespace PaternsOOP.Models
{
    internal class PizzaBuilder : IPizzaBuilder
    {
        private readonly Pizza _pizza = new();
        public IPizzaBuilder SetType(PizzaType type)
        {
            _pizza.Type = type;
            return this;
        }
        public IPizzaBuilder AddTopping(IEnumerable<Topping> toppings)
        {
            _pizza.Toppings = [.. toppings];
            return this;
        }
        public IPizzaBuilder AddExtraTopping(IEnumerable<ExtraTopping> extraToppings)
        {
            _pizza.ExtraToppings = [.. extraToppings];
            return this;
        }
        public Pizza GetPizza() => _pizza;

        public override string ToString() => $"{_pizza.Name} {_pizza.Type} собрана!";
    }
}