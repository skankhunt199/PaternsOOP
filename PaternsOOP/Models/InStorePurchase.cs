namespace PaternsOOP.Models
{
    internal class InStorePurchase : PurchaseProcess
    {
        protected override void Pay()
        {
            Console.WriteLine("Оплата наличными...");
        }

        protected override void ReceiveProduct()
        {
            Console.WriteLine("Получение товара на кассе...");
        }
    }
}