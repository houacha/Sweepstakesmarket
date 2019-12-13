using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        string name;
        public Dictionary<string, Contestants> contestants;
        public Sweepstakes(string name)
        {
            this.name = name; 
            contestants = new Dictionary<string, Contestants>();
        }
        public string Name { get { return name; } }
        public void RegistrerContestants(Contestants contestant)
        {
            contestant.FirstName = UserInterface.SetFirstName();
            contestant.LastName = UserInterface.SetLastName();
            contestant.Email = UserInterface.SetEmail();
            contestant.RegNum = UserInterface.SetRegNum();
            contestants.Add(contestant.RegNum, contestant);
        }
        public string PickWinner()
        {
            Contestants winner = new Contestants();
            Random winningNum = new Random();
            List<string> regNumbers = new List<string>();
            foreach (var item in contestants)
            {
                regNumbers.Add(item.Key);
            }
            winner.RegNum = regNumbers[winningNum.Next(regNumbers.Count)];
            contestants.TryGetValue(winner.RegNum, out winner);
            return winner.FirstName + " " + winner.LastName;
        }
        public void PrintContestantInfo(Contestants contestant)
        {
            Console.WriteLine("Registration Number: " + contestant.RegNum);
            Console.WriteLine("Name: " + contestant.FirstName + " " + contestant.LastName);
            Console.WriteLine("Email: " + contestant.Email);
            Console.ReadLine();
        }
    }
}
