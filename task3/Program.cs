using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int randomNumber = random.Next(50, 76);

            int userNum = 0;
            int count = 0;
            int points = 0;

            while (randomNumber!=userNum)
            {

             count++;

             userNum = Convert.ToInt32(Console.ReadLine());


                if(userNum<randomNumber)
                {
                    Console.WriteLine("Your number is too small. Try again.");
                }
                else if(userNum>randomNumber)
                {
                    Console.WriteLine("Your number is too large. Try again.");
                }

            }
            Console.WriteLine("Congratulations! You guessed the number.");

            if (count == 1)
            {
                points += 10;
            }

            else if (count == 2)
            {
                points += 20;
            }

            else if (count == 3)
            {
                points += 30;
            }

            Console.WriteLine($"You guessed the number in {count} attempts and earned {points} points.");

        }
    }
}
