using System;
namespace Strategy
{
    public class Player
    {
        private IMovingStrategy movingStrategy;
        private string name;

        public Player(string name, IMovingStrategy movingStrategy)
        {
            this.name = name;
            this.movingStrategy = movingStrategy;
            Console.WriteLine($"New player {this.name} has been created");
        }

        public void SetStrategy(IMovingStrategy movingStrategy)
        {
            if(movingStrategy == null)
            {
                throw new Exception();
            }
            this.movingStrategy = movingStrategy;
        }

        public void Move()
        {
            Console.WriteLine($"{this.name} has moved.");
            movingStrategy.Move();
        }
    }
}
