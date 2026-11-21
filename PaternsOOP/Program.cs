using PaternsOOP.Models;
using PaternsOOP.Models.Enums;
using PaternsOOP.Models.Interfaces;

namespace PaternsOOP
{
    class Program
    {
        private static FoodType _foodType = FoodType.Неизвестно;
        private static PizzaType _pizzaType = PizzaType.ЧетыреСыра;
        private static List<Topping> _toppings = [];
        private static List<ExtraTopping> _extraToppings = [];

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в \"Сочно и точка\"!\n\n");
            Console.WriteLine("Что будете кушать?\n");
            Console.WriteLine("[1] Бургер \n[2] Пицца\n");

            ChooseFood();
            ChooseToppings();
            ChooseExstraToppings();

            var factory = new FoodFactory();
            var food = factory.CreateFood(_foodType, _toppings, _extraToppings, _pizzaType);

            PaymentFood(food);
        }

        private static void PaymentFood(IFood food)
        {
            Console.WriteLine("\nСпасибо за заказ! Пожалуйста, оплатите заказ.");
            Console.WriteLine("\nОплата онлайн или наличными?");
            Console.WriteLine("[1] Онлайн \n[2] Наличными\n");
            while (int.TryParse(Console.ReadLine(), out int purchaseType))
            {
                switch (purchaseType)
                {
                    case 1:
                        var onlinePurchase = new OnlinePurchase();
                        onlinePurchase.BuyProduct(food);
                        break;
                    case 2:
                        var inStorePurchase = new InStorePurchase();
                        inStorePurchase.BuyProduct(food);
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите 1 или 2.");
                        break;
                }
            }
        }

        private static void ChooseExstraToppings()
        {
            Console.WriteLine("\nВыберите дополнительные ингредиенты (через запятую, например: 1,2,3...):");
            Console.WriteLine(string.Join("\n", Enum.GetValues<ExtraTopping>().Select((t, i) => $"{i + 1}. {t}")));
            string? extraToppingInput = Console.ReadLine();
            if (string.IsNullOrEmpty(extraToppingInput)) return;
            var extraToppingNumbers = extraToppingInput
                .Split([',', ' ', '.'], StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim());
            _extraToppings = [.. extraToppingNumbers.Select(s => Enum.Parse<ExtraTopping>(s))];

        }
        private static void ChooseToppings()
        {
            Console.WriteLine("\nВыберите начинки (через запятую, например: 1,2,3...):");
            Console.WriteLine(string.Join("\n", Enum.GetValues<Topping>().Select((t, i) => $"{i + 1}. {t}")));
            string? toppingInput = Console.ReadLine();
            if (string.IsNullOrEmpty(toppingInput)) return;
            var toppingNumbers = toppingInput
                .Split([',', ' ', '.'], StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim());
            _toppings = [.. toppingNumbers.Select(s => Enum.Parse<Topping>(s))];
        }

        private static void ChoosePizzaType()
        {
            Console.WriteLine("\nВыберите тип пиццы:");
            Console.WriteLine(string.Join("\n", Enum.GetValues<PizzaType>().Select((t, i) => $"{i + 1}. {t}")));
            string? pizzaTypeInput = Console.ReadLine();
            if (string.IsNullOrEmpty(pizzaTypeInput)) return;
            var pizzaTypeNumbers = pizzaTypeInput
                    .Split([',', ' ', '.'], StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim());
            _pizzaType = Enum.Parse<PizzaType>(pizzaTypeNumbers.First());
        }

        private static void ChooseFood()
        {
            while (_foodType == default)
            {
                Console.Write("Введите номер блюда: ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            _foodType = FoodType.Бургер;
                            Console.WriteLine("Вы выбрали бургер.");
                            break;
                        case 2:
                            _foodType = FoodType.Пицца;
                            Console.WriteLine("Вы выбрали пиццу.");
                            ChoosePizzaType();
                            break;
                        default:
                            Console.WriteLine("Некорректный ввод. Пожалуйста, введите 1 или 2.");
                            break;
                    }
                }
            }
        }
    }
}
