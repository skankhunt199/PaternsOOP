using PaternsOOP.Models.Enums;

namespace PaternsOOP.Models.Interfaces
{
    internal interface IPizzaBuilder 
    {
        IPizzaBuilder SetType(PizzaType type);
        IPizzaBuilder AddTopping(IEnumerable<Topping> toppings);
        IPizzaBuilder AddExtraTopping(IEnumerable<ExtraTopping> extraToppings);
        Pizza GetPizza();
    }
}
