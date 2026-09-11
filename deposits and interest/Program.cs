using System;

namespace despoits_and_interest
{
    class Program
    {
          static  void Main(string[] args)
        {
            decimal clientAmount;
            decimal clientTerm;
            Random random = new Random();

            decimal depositRate = Convert.ToDecimal(random.NextDouble() * (15.86 - 5.25) + 5.25);

            Console.WriteLine("| WELCOME TO THE BANK |" + "\n");

            Console.WriteLine("$ How much would you like to contribute?" + "\n");
            clientAmount = EnterTheNumber();

            Console.WriteLine("$ For what period are you opening the deposit?" + "\n");
            clientTerm = EnterTheNumber();

            Console.WriteLine("$ The current interest rate on the deposit is " + Math.Round(depositRate,2) + "\n");

            Console.WriteLine("$ Your final amount after the period is over is equal to " + Math.Round(clientAmount*clientTerm*depositRate/365, 2));

            return;
        }

        static decimal EnterTheNumber()
        {
            decimal number;

            while (true)
            {
                Console.WriteLine("Enter the number: ");
                string inputAmount = Console.ReadLine();

                if (string.IsNullOrEmpty(inputAmount))
                {
                    Console.WriteLine("\n" + "! INPUT ERROR ! EMPTY STRING ! PLEASE, TRY AGAIN" + "\n");
                    continue;
                }
                else
                {
                    number = Convert.ToDecimal(inputAmount);

                    if (number <= 0)
                    {
                        Console.WriteLine("\n" + "! INPUT ERROR ! THE NUMBER CANNOT BE EQUAL TO ZERO ! PLEASE, TRY AGAIN" + "\n");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
    
            }

            Console.WriteLine("\n" + "$ You entered the number: " + number + "\n\n");
            return number;
        }

    }
}
