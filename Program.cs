using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace making_decisions___homework_random_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 1; 
            int max = 10;

            Write("Guess a number from 1 -10: ");
            int num = int.Parse(Console.ReadLine());

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);

            if (num == randomNumber)
                Write("Random number was {0}, you are correct" ,randomNumber);
            else
                if (num > randomNumber)
                Write("Random number was {0}, too high" ,randomNumber);
            else
            {
                Write("Random number was {0}, too low", randomNumber);
            }
            ReadLine();


        }
    }
}
