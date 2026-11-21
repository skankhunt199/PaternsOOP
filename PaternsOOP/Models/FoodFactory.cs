using PaternsOOP.Models.Enums;
using PaternsOOP.Models.Interfaces;

namespace PaternsOOP.Models
{
    internal class FoodFactory
    {
        private readonly Chef _chef = new();
        public IFood CreateFood(FoodType foodType, IEnumerable<Topping> toppings, IEnumerable<ExtraTopping> extraToppings, PizzaType pizzaType = PizzaType.ЧетыреСыра)
        {
            IFood food = foodType switch
            {
                FoodType.Бургер => _chef.CookBigBurger(toppings, extraToppings),
                FoodType.Пицца => _chef.CookPizza(pizzaType, toppings, extraToppings),
                _ => throw new ArgumentException("Неизвестный тип еды"),
            };
            Console.WriteLine($"Ответ от Factory: выбран тип еды: {foodType}. {food.Name} готова к выдаче!");
            return food;
        }
    }
}