using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13a
{
    class HumanPlayer : Player
    {
        public override string Name()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        public override RPS GenerateRPS()
        {
            Console.Write("Rock, paper, or scissors?: ");

            while (true)
            {
                string throwInput = Console.ReadLine();
                RPS throwChoice;

                if (throwInput.ToLower() != "rock" && throwInput.ToLower() != "paper" && throwInput.ToLower() != "scissors")
                {
                    Console.Write("Invalid response. Please enter a valid throw: ");
                }

                else
                {
                    throwChoice = (RPS)Enum.Parse(typeof(RPS), throwInput.ToLower());
                    return throwChoice;
                } 
            }
        }
    }
}
