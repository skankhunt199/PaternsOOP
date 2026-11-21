using PaternsOOP.Models.Enums;
using PaternsOOP.Models.Interfaces;

namespace PaternsOOP.Models
{
    internal class BurgerBuilder : IBurgerBuilder
    {
        private readonly Burger _burger = new();
        public IBurgerBuilder SetSize(BurgerSize size)
        {
            _burger.Size = size;
            return this;
        }
        public IBurgerBuilder AddTopping(IEnumerable<Topping> toppings) 
        { 
            _burger.Toppings = [.. toppings];
            return this;
        }
        public IBurgerBuilder AddExtraTopping(IEnumerable<ExtraTopping> extraToppings) 
        { 
            _burger.ExtraToppings = [.. extraToppings];
            return this;
        }
        public Burger GetBurger() => _burger;

        public override string ToString() => $"{_burger.Size} {_burger.Name} собран!";
    }
}
