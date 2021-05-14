using System;
namespace Strategy
{
    public class Dash : IMovingStrategy
    {
        public Dash()
        {
        }

        public void Move()
        {
            Console.WriteLine("Dashing");
        }
    }
}
