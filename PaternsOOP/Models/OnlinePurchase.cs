namespace PaternsOOP.Models
{
    internal class OnlinePurchase : PurchaseProcess
    {
        protected override void Pay()
        {
            Console.WriteLine("Оплата онлайн...");
        }

        protected override void ReceiveProduct()
        {
            Console.WriteLine("Ожидание доставки курьером...");
        }
    }
}