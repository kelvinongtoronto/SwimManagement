using SwimManagementLibrary.structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimManagementLibrary.classes
{
    public abstract class Registrant
    {
        protected Club club;

        public virtual Club Club
        {
            get
            {
                return club;
            }
            set
            {
                club = value;
            }
        }
        public Address Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public uint Id { get; }
        public string Name { get; set; }
        public ulong PhoneNumber { get; set; }

        public Registrant()
        {
            Id = RegistrationNumberGenerator.GetNext();
        }

        public Registrant(string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber) : this()
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = anAddress;
            PhoneNumber = phoneNumber;
        }

        // used only internally within the library
        internal Registrant(uint regNumber, string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber) : this(name, dateOfBirth, anAddress, phoneNumber)
        {
            Id = regNumber;
        }
        public override string ToString()
        {
            string registrantInformation = $"Name: {Name}\nAddress: {Address}\n";
            registrantInformation += $"Phone: {PhoneNumber}\nDOB: {DateOfBirth}\nId: {Id}\n";
            registrantInformation += (club != null) ? $"Club: {club.Name}" : "Club: Not Assigned";

            return registrantInformation;
        }
    }
}
