using System;

namespace ConsoleAppCore
{
    class SealedClassNdMember : ITask
    {
        void ITask.Execute()
        {
            Console.WriteLine("In SealedClassNdMember");
            DerivedClass ob1 = new DerivedClass();
            ob1.Display();
        }


        public class BaseClass
        {

            public virtual void Display()
            {
                Console.WriteLine("Virtual method");
            }
        }

        public class DerivedClass : BaseClass
        {
            public override sealed void Display()
            {
                Console.WriteLine("Sealed method");
            }
        }

    }


}
