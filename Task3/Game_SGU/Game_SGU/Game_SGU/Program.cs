using System;
using Game_SGU.Logic_GM;

namespace Game_SGU
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.StartGame();

            Console.ReadKey();
        }
    }
}
