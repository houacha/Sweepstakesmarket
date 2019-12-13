using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerCreator manager = new ManagerCreator();
            MarketingFirm marketingFirm = new MarketingFirm(manager.MakeAManager(UserInterface.ChooseManager()));
            marketingFirm.Start();
        }
    }
}
