using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        ISweepstakeManager manager;
        public MarketingFirm(ISweepstakeManager manager)
        {
            this.manager = manager;
        }
        public void Start()
        {
            Sweepstakes sweepstakes = null;
            int sweepstakesAmount = UserInterface.SetAmountOfSweepstakes();
            for (int i = 0; i < sweepstakesAmount; i++)
            { 
                sweepstakes = new Sweepstakes(UserInterface.SetSweepstake());
                int amountOfContestants = UserInterface.SetAmountOfContestants();
                for (int j = 0; j < amountOfContestants; j++)
                {
                    sweepstakes.RegistrerContestants(new Contestants());
                }
                manager.InsertSweepstakes(sweepstakes);
            }
            for (int j = 0; j < sweepstakesAmount; j++)
            {
                Sweepstakes current;
                current = manager.GetSweepstakes();
                current.PickWinner();
            }
            Console.ReadLine();
        }
    }
}
