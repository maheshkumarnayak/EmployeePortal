using ConsoleAppCore.Factory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppCore
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory taskfactory = new TaskFactory();
            ITask task= taskfactory.GetTask(TaskType.SumValueinArray);
            task.Execute();
            Console.ReadKey();
        }
    }
}
