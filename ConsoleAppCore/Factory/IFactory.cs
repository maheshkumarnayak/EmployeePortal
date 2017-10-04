using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCore.Factory
{
    public interface IFactory
    {
        ITask GetTask(TaskType type);
    }
}
