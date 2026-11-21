using PaternsOOP.Models.Enums;
using PaternsOOP.Models.Interfaces;

namespace PaternsOOP.Models
{
    internal class FoodFactory
    {
        private readonly Chef _chef = new();
        public IFood CreateFood(FoodType foodType, IEnumerable<Topping> toppings, IEnumerable<ExtraTopping> extraToppings,
            PizzaType pizzaType = PizzaType.ЧетыреСыра, BurgerSize burgerSize = BurgerSize.Большой)
        {
            IFood food = foodType switch
            {
                FoodType.Бургер => _chef.CookBurger(burgerSize, toppings, extraToppings),
                FoodType.Пицца => _chef.CookPizza(pizzaType, toppings, extraToppings),

                _ => throw new ArgumentException("Неизвестный тип еды"),
            };
            Console.WriteLine($"Ответ от FoodFactory: выбран тип еды: {foodType}. Еда приготовлена и готова к выдаче!");
            return food;
        }
    }
}