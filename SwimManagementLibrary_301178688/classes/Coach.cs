using SwimManagementLibrary.structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimManagementLibrary.classes
{
    public class Coach : Registrant
    {
        string Credentials { get; set; }

        public Coach(string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber, string credentials) :
            base(name, dateOfBirth, anAddress, phoneNumber) {
            Credentials = credentials;
        }

        public override string ToString() {
            return base.ToString() + $"\nCredentials: {Credentials}";
        }
    }
}
