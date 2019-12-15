using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakeManagerQueue: ISweepstakeManager
    {

        Queue<Sweepstakes> sweepstakes;
        public SweepstakeManagerQueue()
        {
            sweepstakes = new Queue<Sweepstakes>();
        }
        void ISweepstakeManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {
            this.sweepstakes.Enqueue(sweepstakes);
        }
        Sweepstakes ISweepstakeManager.GetSweepstakes()
        {
            return sweepstakes.Dequeue();
        }
    }
}
