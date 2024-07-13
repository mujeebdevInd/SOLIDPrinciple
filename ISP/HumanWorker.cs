using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    //Before ISP
    //public class HumanWorker : IWorker
    //{
    //    public void Work()
    //    {
    //        Console.WriteLine("Human is working.");
    //    }

    //    public void Eat()
    //    {
    //        Console.WriteLine("Human is eating.");
    //    }

    //    public void Sleep()
    //    {
    //        Console.WriteLine("Human is sleeping.");
    //    }
    //}

    //public class RobotWorker : IWorker
    //{
    //    public void Work()
    //    {
    //        Console.WriteLine("Robot is working.");
    //    }

    //    public void Eat()
    //    {
    //        // Not applicable to robots
    //        throw new NotImplementedException();
    //    }

    //    public void Sleep()
    //    {
    //        // Not applicable to robots
    //        throw new NotImplementedException();
    //    }
    //}

    public class HumanWorker : IWork, IEat, ISleep
    {
        public void Work()
        {
            Console.WriteLine("Human is working.");
        }

        public void Eat()
        {
            Console.WriteLine("Human is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("Human is sleeping.");
        }
    }

    public class RobotWorker : IWork
    {
        public void Work()
        {
            Console.WriteLine("Robot is working.");
        }
    }
}
