using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13a
{
    public class RPSApp

    {
        public string CreatePlayer()
        {
            var humanPlayer = new HumanPlayer();

            //Console.Write("Would you like to play against the Warrior or the Beast? Please type 'warrior' or 'beast': ");
            //string opponent = Console.ReadLine();

            while (true)
            {
                Console.Write("Would you like to play against the Warrior or the Beast? Please type 'warrior' or 'beast': ");
                string opponent = Console.ReadLine();

                if ((opponent.ToLower() != "warrior" && opponent.ToLower() != "beast"))

                {
                    Console.WriteLine("Invalid response. Please enter either 'warrior' or 'beast': ");
                }
                else return opponent;
            }

        }

        public RPS ChooseOpponent(string opponent)
        {
            var randomPlayer = new RandomPlayer();
            RPS randomThrow = randomPlayer.GenerateRPS();

            var rockPlayer = new RockPlayer();
            RPS rockThrow = rockPlayer.GenerateRPS();


            switch (opponent.ToLower())
            {
                case "warrior":
                    return rockThrow;

                case "beast":
                    return randomThrow;

                default:
                    throw new ArgumentOutOfRangeException(nameof(opponent));
            }
        }
    }
}

