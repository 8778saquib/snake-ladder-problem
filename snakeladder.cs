using System;
using System.Diagnostics;

namespace snake_ladder_problem
{
  //*****intial position**********

    public class snakeladder
    {
        int position = 0;
        int dice;
        Random random = new Random();

        public void Start()
        {
            Console.WriteLine("The initial position of player {0}", position);

        }

        //******roll die********

        public void rolldie()
        {
            dice = random.Next(1, 7);
            Console.WriteLine("The roll the die and get {0}", dice);

        }

        //******************checking*****************

        public void Check()
        {

           
            int num1 = random.Next(0, 3);

            switch (num1)
            {
                case 0:
                    Console.WriteLine("No play is available");
                    break;

                case 1:
                    position = position + dice;
                    Console.WriteLine("the postion of player {0}", position);
                    break;

                case 2:
                    position = position - dice;
                    Console.WriteLine("the postion of player if snake bite {0}", position);
                    break;
            }
        }
    }
}



