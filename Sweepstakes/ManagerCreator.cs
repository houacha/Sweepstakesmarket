using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class ManagerCreator: IChooseManager
    {
        public ISweepstakeManager MakeAManager(string manager)
        {
            switch (manager)
            {
                case "stack":
                    return new SweepstakeManagerStack();
                case "queue":
                    return new SweepstakeManagerQueue();
                default:
                    throw new Exception("Not a valid manager type.");
            }
        }

    }
}
