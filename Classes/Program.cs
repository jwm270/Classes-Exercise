namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne  =   new Car();
            carOne.Make = "BMW";
            carOne.Model = "Slow";
            carOne.Year = 2000;

            Console.WriteLine($"This is a {carOne.Make} and {carOne.Model} made in the year {carOne.Year}.");
        }
    }
}
