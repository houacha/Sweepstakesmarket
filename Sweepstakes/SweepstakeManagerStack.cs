using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakeManagerStack: ISweepstakeManager
    {
        Stack<Sweepstakes> sweepstakes;
        public SweepstakeManagerStack()
        {
            sweepstakes = new Stack<Sweepstakes>();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            this.sweepstakes.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakes.Pop();
        }
    }
}
