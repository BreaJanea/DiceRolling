using System;

namespace DiceRolling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Casino");
            Console.Write("How many sides should each die have?: ");
            int input = int.Parse(Console.ReadLine());

            do
            {
                int die1 = DiceRoll(input);
                int die2 = DiceRoll(input);

                OutputMessage(die1, die2, input);
            } 
                while (userContinue());
        }

        static int DiceRoll (int num)
        {
            Random random = new Random();
            int randomNum = random.Next(1, num+1);
            return randomNum;
        }

        static void OutputMessage(int dice1, int dice2, int sides)
        {
            int dicetotal = dice1 + dice2;
            Console.WriteLine($"You rolled a {dice1} and a {dice2} ({dicetotal} total).");

            if (sides == 6)
            {
                if (dice1 == 1 && dice2 == 1)
                {
                    Console.WriteLine("Snake Eyes");
                }

                if (dice1 == 1 && dice1 == 2 || dice1 == 2 && dice2 == 1)
                {
                    Console.WriteLine("Ace Deuce");
                }

                if (dice1 == 6 && dice2 == 6)
                {
                    Console.WriteLine("Box Cars");
                }

                if (dicetotal == 7 || dicetotal == 11)
                {
                    Console.WriteLine("WIN!");
                }
                if (dicetotal == 2 || dicetotal == 3 || dicetotal == 12 )
                {
                    Console.WriteLine("CRAP!");
                }
            }
        }

        static bool userContinue()
        {
            char c;
            do
            {
                Console.Write("Would you like to continue? (y/n)?  ");
                c = Console.ReadKey().KeyChar;
                if (c == 'n' || c == 'N')
                {
                    Console.WriteLine("See ya!");
                    return false;
                }
                Console.WriteLine();
            } while (c != 'y' && c != 'Y');
            return true;
        }

    }
}
