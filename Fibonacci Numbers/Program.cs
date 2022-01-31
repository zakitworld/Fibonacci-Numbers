using System;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int previous1;
            int previous2;
            int current;
            int counter;
            int nthFibonacci;
            Console.WriteLine("Enter the first two Fibonacci Numbers: ");
            previous1 = Convert.ToInt32(Console.ReadLine());
            previous2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first two Fibonacci Numbers are: " + previous1 + " and " + previous2);
            Console.WriteLine("Enter the position of the desired Fibonacci Number: ");
            nthFibonacci = Convert.ToInt32(Console.ReadLine());
            if (nthFibonacci == 1)
                current = previous1;
            else if (nthFibonacci == 2)
                current = previous2;
            else
            {
                counter = 3;
                while (counter <= nthFibonacci)
                {
                    current = previous2 + previous1;
                    previous1 = previous2;
                    previous2 = current;
                    counter++;
                }
                //end while
            }
            //end else
            Console.WriteLine("The Fibonacci Number at position " + nthFibonacci + " " +"is" + " "+ current);
        }
    }
}

