using System;
namespace snake_ladder_problem
{
    public class snakeladder
    {
        int initialposition = 0;
        Random random = new Random();

        public void Start()
        {
            Console.WriteLine("The initial position of player {0}", initialposition);

        }
        public void rolldie()
        {
            int num = random.Next(0, 7);
            Console.WriteLine("The roll the die and get {0}", num);

        }

    }

}
