using System;


namespace TestStatements
{
    public class Statements
    {
        static void Main(string[] args)
        {
            string Car = "car";
            string BMW = "car";

            if (Car == BMW)
            {
                Console.WriteLine("BMW is equal as a Car!");
            }
            else
            {
                Console.WriteLine("BMW isn't equal as a Car!");
            }
        }
    }
}