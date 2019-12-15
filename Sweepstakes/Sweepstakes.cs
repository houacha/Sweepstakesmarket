using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        string name;
        public Dictionary<string, Contestants> contestants;
        private Contestants winner;
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
            winner = new Contestants();
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
        public void SendMessage()
        {
            var message = new MimeMessage();
            foreach (var item in contestants)
            {
                if (item.Key.Equals(winner.RegNum))
                {
                    message.From.Add(new MailboxAddress(name, "sweepstakes.com"));
                    message.To.Add(new MailboxAddress(winner.FirstName + " " + winner.LastName, winner.Email));
                    message.Subject = "You Are The Winner!!";
                    message.Body = new TextPart("plain")
                    {
                        Text = @"Winner,
                    Congradulation, You have won the sweepstake."
                    };
                }
                else
                {
                    message.From.Add(new MailboxAddress(name, "sweepstakes.com"));
                    message.To.Add(new MailboxAddress(item.Value.FirstName + " " + item.Value.LastName, winner.Email));
                    message.Subject = "Sweepstake";
                    message.Body = new TextPart("plain")
                    {
                        Text = @"Contestants,
                    Unfortunately, you didn't win this contestant."
                    };
                }
            }
        }
    }
}
