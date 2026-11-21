using PaternsOOP.Models.Interfaces;

namespace PaternsOOP.Models
{
    internal abstract class PurchaseProcess
    {        
        public void BuyProduct(IFood food)
        {
            Console.WriteLine($"\n--- Начинаем процесс оплаты: {food.Name} ---");
            SelectProduct(food);
            Pay();
            ReceiveProduct();
            Console.WriteLine("--- Оплата завершена. Спасибо за покупку! ---\n");
        }
        protected void SelectProduct(IFood food)
        {
            Console.WriteLine($"Выбран товар: {food}");
        }       
        protected abstract void Pay();
        protected abstract void ReceiveProduct();
    }
}
