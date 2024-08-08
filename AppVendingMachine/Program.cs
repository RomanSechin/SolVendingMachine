namespace AppVendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
            {
            VendingMachine vendingMachine = new AnimalFeedVendingMachine();
           
            Console.WriteLine(vendingMachine.Dispence(2.00M));
        }
    }
}
