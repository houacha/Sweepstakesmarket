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

        //Example code for marketing firm to put in contestants, pick winner, and send messages
        public void Start()
        {
            int sweepstakesAmount = UserInterface.SetAmountOfSweepstakes();
            for (int i = 0; i < sweepstakesAmount; i++)
            { 
                Sweepstakes sweepstakes = null;
                sweepstakes = new Sweepstakes(UserInterface.SetSweepstake());
                int amountOfContestants = UserInterface.SetAmountOfContestants();
                for (int j = 0; j < amountOfContestants; j++)
                {
                    Contestants contestants = new Contestants();
                    sweepstakes.RegistrerContestants(contestants);
                    sweepstakes.PrintContestantInfo(contestants);
                }
                manager.InsertSweepstakes(sweepstakes);
            }
            for (int j = 0; j < sweepstakesAmount; j++)
            {
                Sweepstakes current;
                current = manager.GetSweepstakes();
                Console.WriteLine(current.PickWinner());
                current.SendMessage();
            }
            Console.ReadLine();
        }
    }
}
