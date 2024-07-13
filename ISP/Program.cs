using ISP;

class Program
{
    static void Main(string[] args)
    {
        IWork humanWorker = new HumanWorker();
        humanWorker.Work();

        IEat eatingHuman = new HumanWorker();
        eatingHuman.Eat();

        ISleep sleepingHuman = new HumanWorker();
        sleepingHuman.Sleep();

        IWork robotWorker = new RobotWorker();
        robotWorker.Work();
    }
}