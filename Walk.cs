using System;
namespace Strategy
{
    public class Walk : IMovingStrategy
    {
        public Walk()
        {
        }

        public void Move()
        {
            Console.WriteLine("Walking");
        }
    }
}
