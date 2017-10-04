using System;

namespace ConsoleAppCore
{
    class DefaultTask : ITask
    {
        void ITask.Execute()
        {
            Console.WriteLine("In default");
        }
    }
}
