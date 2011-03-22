using System;

namespace Trolopoloy
{
    class Dice
    {
        private Random rand;

        public Dice()
        {
            rand = new Random();
        }

        public Roll Roll()
        {   
            //Simulates roll of dice i.e. two random numbers between 1 and 6
            int dice1 = rand.Next(1, 6);
            int dice2 = rand.Next(1, 6);
            Roll newRoll = new Roll(dice1 + dice2, dice1 == dice2 ? true : false);

            Console.WriteLine("git test 2");

            return newRoll;

            
        }
    }
}
