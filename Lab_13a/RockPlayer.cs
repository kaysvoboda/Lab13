using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13a
{
    public class RockPlayer : Player
    {

        public override string Name()
        {
            string name = "Warrior";
            return name;
        }

        public override RPS GenerateRPS()
        {
            return  RPS.rock;
        }

    }
}
