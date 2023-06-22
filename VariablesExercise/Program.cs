namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Chachy";
            int age = 22;
            char middleInitial = 'a';
            bool isOver18YearsOld = true;
            double currentTemp = 60;
            decimal currentPrice = 77.07m;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Middle Initial: {middleInitial}");
            Console.WriteLine($"Is Over 18: {isOver18YearsOld}");
            Console.WriteLine($"Current Temperature: {currentTemp}");
            Console.WriteLine($"Current Price: {currentPrice}");
        }
    }
}