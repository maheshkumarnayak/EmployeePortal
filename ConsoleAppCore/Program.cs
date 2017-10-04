using System;

namespace ConsoleAppCore
{
    class Program
    {
        static void Main(string[] args)
        {
            ITask task = new SealedClassNdMember();
            task.Execute();
            Console.ReadKey();
        }
    }
}
