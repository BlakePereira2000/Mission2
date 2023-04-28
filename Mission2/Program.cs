using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate? ");
            int numDice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS " + "\n" +
                "Each \"*\" represents 1 % of the total number of rolls. " + "\n" +
                "Total number of rolls = 1000.");

            int[] diceCount = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Random rd = new Random();

            for (int i=0; i<numDice; i++)
            {
                int rand_num1 = rd.Next(1, 7);
                int rand_num2 = rd.Next(1, 7);
                int total = rand_num1 + rand_num2;
                diceCount[total -2] += 1; 
            }

            for (int i=0; i<11; i++)
            {
                Console.Write((i + 2) + ": ");
                int percent = (diceCount[i] * 100) / numDice;
                for (int j = 0; j < percent; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
