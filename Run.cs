using System;
namespace Strategy
{
    public class Run : IMovingStrategy
    {
        public Run()
        {
        }

        public void Move()
        {
            Console.WriteLine("Running");
        }
    }
}
