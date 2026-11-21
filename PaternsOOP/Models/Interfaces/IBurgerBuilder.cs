using PaternsOOP.Models.Enums;

namespace PaternsOOP.Models.Interfaces
{
    internal interface IBurgerBuilder
    {
        IBurgerBuilder SetSize(BurgerSize size);
        IBurgerBuilder AddTopping(IEnumerable<Topping> toppings);
        IBurgerBuilder AddExtraTopping(IEnumerable<ExtraTopping> extraToppings);
        Burger GetBurger();
    }
}