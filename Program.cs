using System;

namespace snake_ladder_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake ladder problem");
            snakeladder obj = new snakeladder();
            obj.Start();
            obj.rolldie();
            obj.Check();
          
            obj.Repeat();
           obj.Exactwin();


        }
    }
}
