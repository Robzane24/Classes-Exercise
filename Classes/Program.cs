namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Honda";
            myCar.Model = "Civic";
            myCar.Year = 2009;


            Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year}");
        }
        
    }
}
