using System;

namespace Root_Beer_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many bottles of Root Beer do you want to take off the wall. Please put a number in that is above 0.");
            int x = int.Parse(Console.ReadLine());
            countRootBeer(x);
            
            Console.ReadLine();
        }

        private static void countRootBeer(int x)
        {
            int counter = -1;
            while (counter < x)
            {
                Console.WriteLine("");
                Console.Write("{0} bottles of root beer on the wall {0} bottles of root beer. Take one down and pass it around {1} bottles of root beer on the wall.", x, x - 1);
                x--;
            }
        }
    }
}
