using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestants
    {
        string firstName;
        string lastName;
        string regNum;
        string email;
        public Contestants()
        { 
        }
        public string RegNum { get { return regNum; } set { regNum = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Email { get { return email; } set { email = value; } }
    }
}
