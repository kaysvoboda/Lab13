using System;

namespace Lab_13a
{
    class Program
    {
        static void Main(string[] args)
        {      
            var opponent = new RPSApp();
            string continueInput;

            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

            Player humanPlayer = new HumanPlayer();
            string humanName = humanPlayer.Name();

            do
            { 
                RPS humanThrow = humanPlayer.GenerateRPS();
                string opponentName = opponent.CreatePlayer();
                RPS opponentThrow = opponent.ChooseOpponent(opponentName);

                Console.WriteLine($"{humanName} : {humanThrow}");
                Console.WriteLine($"{opponentName} : { opponentThrow}");


                int opponentThrowInt = (int)opponentThrow;
                int humanThrowInt = (int)humanThrow;


                if (opponentThrowInt == humanThrowInt)
                {
                    Console.WriteLine("Draw!");
                }
                else if ((opponentThrowInt == 0 && humanThrowInt == 2) || (opponentThrowInt == 1 && humanThrowInt == 0) || (opponentThrowInt == 2 && humanThrowInt == 1))

                {
                    Console.WriteLine($"{opponentName} Wins!");
                }
                else 
                    Console.WriteLine($"{humanName} Wins!");
                    Console.Write("Would you like to continue playing? (y/n): ");
                    continueInput = Console.ReadLine();

            } while (continueInput == "y");
        } 
    }
}
