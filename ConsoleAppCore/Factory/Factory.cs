using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCore.Factory
{
    public class TaskFactory: IFactory
    {
        ITask IFactory.GetTask(TaskType type)
        {
            ITask task;
           switch (type)
            {
                case TaskType.InheritenceTask:
                    task = new InheritenceTask();
                    break;
                case TaskType.SumValueinArray:
                    task = new SumValueinArray();
                    break;
                case TaskType.DefaultTask:
                    task = new DefaultTask();
                    break;
                default:
                    task = new DefaultTask();
                    break;
            }
            return task;
        }

    }
}
