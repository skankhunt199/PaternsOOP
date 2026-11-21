using PaternsOOP.Models.Enums;

namespace PaternsOOP.Models.Interfaces
{
    internal interface IFood
    {
        string Name { get; }
        public List<Topping> Toppings { get; set; } 
        public List<ExtraTopping> ExtraToppings { get; set; }
    }
}