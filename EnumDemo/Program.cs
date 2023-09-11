namespace EnumDemo
{
    enum Beverage
    {
        Coffee,
        Tea,
        Water,
        Soda,
        Juice
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the awesome vending machine");
            Console.WriteLine("Which beverage do you prefer? (Coffee, Tea, Water, Soda, Juice)");
            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "coffee":
                    Respond(Beverage.Coffee);
                    break;
                case "tea":
                    Respond(Beverage.Tea);
                    break;
                case "water":
                    Respond(Beverage.Water);
                    break;
                case "soda":
                    Respond(Beverage.Soda);
                    break;
                case "juice":
                    Respond(Beverage.Juice);
                    break;
                default:
                    Console.WriteLine("Invalid input, this drink does not exist.");
                    break;
            }

        }

        static void Respond(Beverage drink)
        {
            switch (drink)
            {
                case Beverage.Coffee:
                    Console.WriteLine("You ordered Kaffe Latte");
                    break;
                case Beverage.Tea:
                    Console.WriteLine("You ordered Tea, jukky");
                    break;
                case Beverage.Water:
                    Console.WriteLine("You chose water, Why though??");
                    break;
                case Beverage.Soda:
                    Console.WriteLine("Nice choice , Bebsi cola");
                    break;
                case Beverage.Juice:
                    Console.WriteLine("One orange juice coming your way!");
                    break;

            }
        }

    }
}