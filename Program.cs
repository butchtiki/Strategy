using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player("Butch", new Walk());
            newPlayer.Move();

            newPlayer.SetStrategy(new Run());
            newPlayer.Move();

            newPlayer.SetStrategy(new Dash());
            newPlayer.Move();
        }
    }
}
