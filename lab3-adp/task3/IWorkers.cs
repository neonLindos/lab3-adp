using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_adp.task3
{
    public interface IHumanWorker 
    {
        void Eat();
        void Sleep();
        void Work();

    }

    public interface IRobotWorker
    {
        void Work();
    }

}
