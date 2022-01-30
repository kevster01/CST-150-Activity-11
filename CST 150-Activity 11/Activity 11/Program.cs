using System;

//Kevin Reynoso//CST 150//1/30/2022//This is my own work 


namespace Activity_11
{
    public class Dice
    {
        private int numberOfSides;

       


        private static Random newDiceside = new Random();

        public Dice(int numberOfSides)
        {

            if (numberOfSides < 4 || numberOfSides > 20)
            {
                throw new ArgumentOutOfRangeException("Should be in range of 4-20");
            }

            this.numberOfSides = numberOfSides;
        }

        public int rollDie()
        {
            return newDiceside.Next(1, numberOfSides + 1);
        }

    }

    public class DieTest
    {
        public static void Main()
        {
            Dice Dice1 = new Dice(6);
            Dice Dice2 = new Dice(6);

            int d1Roll, d2Roll;
            int numberOfRolls = 0;

            do
            {

                d1Roll = Dice1.rollDie();
                d2Roll = Dice2.rollDie();

                Console.WriteLine("Rolled [Dice 1: " + d1Roll + ", Dice 2: " + d2Roll + "]");

                ++numberOfRolls;

            } while (d1Roll != 1 || d2Roll != 1);

            Console.WriteLine("\nIt took " + numberOfRolls + " rolls to get snake eyes!");
        }
    }
}