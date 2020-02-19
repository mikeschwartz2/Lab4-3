using System;

namespace Lab4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRIME NUMBER CHECKER");
            
            string rerun = "";
            do
            {
                Console.WriteLine("====================================================");
                Console.Write("What prime number would you like to check: Enter number 1-10 ");
                int input = int.Parse(Console.ReadLine());

                Console.WriteLine($"The prime number at position #{input} is {PrimeNumbers.GetPrime(input)}");

                rerun = Rerun(rerun);
            }
            while (rerun == "y");

            Console.WriteLine("Bye. Thank you for using the prime number checker!!!");
        }

        static string Rerun(string rerun)
        {
            Console.WriteLine("Would you like to check another prime number? y/n");
            rerun = Console.ReadLine();
            rerun = rerun.ToLower();

            while (rerun != "y" && rerun != "n")
            {
                Console.WriteLine("This is not a valid input. Would you like to check another prime number: y/n");
                rerun = Console.ReadLine();
                rerun = rerun.ToLower();
            }
            return rerun;
        }
    }
}
