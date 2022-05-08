using System;
using System.Diagnostics;

namespace snake_ladder_problem
{
    //*****intial position**********

    public class snakeladder
    {

        int position = 0;
        int dice;
        int dice2;
        int playerposition1 = 0;
        int playerposition2 = 0;
        //int playerposition3 = 0;
        int Noofdice;
        //int Noofdiceroll;


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
            int dice1 = random.Next(1, 7);


            switch (num1)
            {
                case 0:
                    Console.WriteLine("No play is available");
                    break;

                case 1:
                    playerposition1 = playerposition1 + dice1;
                    Console.WriteLine("the postion of player0 {0}", playerposition1);
                    break;

                case 2:
                    playerposition1 = playerposition1 - dice1;
                    Console.WriteLine("the postion of player0 if snake bite {0}", playerposition1);
                    break;
            }
        }
        //********************reapeat***********
        public void Repeat()
        {
            while (playerposition2 < 100)
            {
                Noofdice++;
                int num2 = random.Next(0, 2);
                dice2 = random.Next(1, 7);
                switch (num2)
                {


                    case 0:
                        playerposition2 = playerposition2 + dice2;
                        Console.WriteLine("the postion of player2 {0}", playerposition2);
                        break;

                    case 1:
                        if (playerposition2 < 0)
                        {
                            Console.WriteLine("the postion of player2 {0}", playerposition2 = 0);
                        }
                        else
                        {
                            playerposition2 = playerposition2 - dice2;
                            Console.WriteLine("the postion of player2 if snake bite {0}", playerposition2);
                        }
                        break;

                }
                Console.WriteLine("the present position of player3 {0}", playerposition2);



            }
            Console.WriteLine("the end position of player{0}", playerposition2);
            Console.WriteLine("no of dice roll{0}:", Noofdice);
        }
        //****************exactwin*****************




    }
}






