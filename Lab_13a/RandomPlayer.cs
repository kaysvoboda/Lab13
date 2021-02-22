using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13a
{
    class RandomPlayer : Player
    {
        public override string Name()
        {
            return "Beast";
        }
        public override RPS GenerateRPS()
        {
            var random = new Random();
            RPS randomEnum = (RPS)random.Next(0, 3);
            return randomEnum;
        }
    }
}
