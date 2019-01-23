using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Good
            //setup

            Single Division = 0;
            
            //input

            Console.WriteLine("what is the distance traveled in miles?");
            var miles = Single.Parse(Console.ReadLine());

            Console.WriteLine("How many gallons used to fill the tank?");
            var gallons = Single.Parse(Console.ReadLine());

            //processing
            Division = miles / gallons;
            

            //output

            Console.WriteLine("Division of " + miles + " + " + gallons + " equals a MPG of " + Division );
            Console.ReadLine();
        
        }
    }
}
