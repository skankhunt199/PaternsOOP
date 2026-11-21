using PaternsOOP.Models.Enums;
using PaternsOOP.Models.Interfaces;

namespace PaternsOOP.Models
{
    internal class Burger : IFood
    {        
        public string Name => "Бургер";
        public BurgerSize Size { get; set; }
        public List<Topping> Toppings { get; set; } = [];
        public List<ExtraTopping> ExtraToppings { get; set; } = [];

        public override string ToString()
        {
            var toppingsList = Toppings.Count > 0 ? string.Join(", ", Toppings) : "без начинки";
            var extraToppingsList = ExtraToppings.Count > 0 ? string.Join(", ", ExtraToppings) : "без дополнительных ингредиентов";
            return $"{Size} бургер с начинкой: {toppingsList}, дополнительные ингредиенты: {extraToppingsList}";
        }
    }
}