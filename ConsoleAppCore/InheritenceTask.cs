using ConsoleAppCore.Factory;
using System;

namespace ConsoleAppCore
{
    class InheritenceTask : ITask
    {
        void ITask.Execute()
        {
            Console.WriteLine("In InheritenceDetails");
            Ib obj = new Ca();
            obj.dosomething();
        }
    }


    public interface Ia
    {
        void dosomething();

    }
    public interface Ib
    {
        void dosomething();

    }

    public class Ca : Ia, Ib
    {
        void Ia.dosomething()
        {
            Console.WriteLine("In IA");
        }

        void Ib.dosomething()
        {
            Console.WriteLine("In IB");
        }
    }


}
