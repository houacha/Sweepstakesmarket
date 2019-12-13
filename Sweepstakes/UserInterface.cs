using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        public static string SetFirstName()
        {
            Console.Clear();
            Console.WriteLine("What is the first name of the contestant?");
            return Console.ReadLine();
        }
        public static string SetLastName()
        {
            Console.Clear();
            Console.WriteLine("What is the last name of the contestant?");
            return Console.ReadLine();
        }
        public static string SetEmail()
        {
            Console.Clear();
            Console.WriteLine("What is the email of the contestant?");
            return Console.ReadLine();
        }
        public static string SetRegNum()
        {
            Console.Clear();
            Console.WriteLine("What is the registration number of the contestant?");
            return Console.ReadLine();
        }
        public static string ChooseManager()
        {
            string answer;
            do
            {
                Console.Clear();
                Console.WriteLine("How would you like your sweepstakes to be managed? Enter 'stack' or 'queue'.");
                answer = Console.ReadLine().ToLower();
            } while (answer != "stack" && answer != "queue");
            return answer;
        }
        public static string SetSweepstake()
        {
            Console.Clear();
            Console.WriteLine("What is the name of sweepstake?");
            return Console.ReadLine();
        }
        public static int SetAmountOfContestants()
        {
            string amount;
            int result;
            do
            {
                Console.Clear();
                Console.WriteLine("How many contestants are entering?");
                amount = Console.ReadLine();
            } while (Int32.TryParse(amount, out result) == false);
            return result;
        }
        public static int SetAmountOfSweepstakes()
        {
            string amount;
            int result;
            do
            {
                Console.Clear();
                Console.WriteLine("How many sweepstakes do you want to input?");
                amount = Console.ReadLine();
            } while (Int32.TryParse(amount, out result) == false);
            return result;
        }
    }
}
