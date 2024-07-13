using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    //Before ISP
    //public interface IWorker
    //{
    //    void Work();
    //    void Eat();
    //    void Sleep();
    //}
    public interface IWork
    {
        void Work();
    }

    public interface IEat
    {
        void Eat();
    }

    public interface ISleep
    {
        void Sleep();
    }

}
