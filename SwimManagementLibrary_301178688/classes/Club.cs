using SwimManagementLibrary.structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimManagementLibrary.classes
{
    public class Club
    {
        private Coach coach;

        public Address ClubAddress { get; set; }
        public uint ClubNumber { get; set; }
        public string Name { get; set; }
        public ulong PhoneNumber { get; set; }
        private List<Registrant> Swimmers { get; }
        public Coach Coach
        {
            get 
            {
                return coach;
            }
            set
            {
                if (coach == null)
                {
                    coach = value;
                    if (value != null)
                        value.Club = this;
                }
                else
                {
                    coach.Club = null; //set existing coach to null
                    coach = value;
                    if (value != null)
                        value.Club = this;
                }
            } 
        }

        public Club() :
            this(RegistrationNumberGenerator.GetNext(), string.Empty, new Address("", "", "", ""), 0) {

        }

        public Club(string name, Address anAddress, ulong phoneNumber) : 
            this(RegistrationNumberGenerator.GetNext(), name, anAddress, phoneNumber) {
        }

        internal Club(uint regNumber, string name, Address anAddress, ulong phoneNumber) {
            Name = name;
            ClubAddress = anAddress;
            PhoneNumber = phoneNumber;
            ClubNumber = regNumber;
            Swimmers = new List<Registrant>();
        }

        public void AddSwimmer(Registrant aSwimmer) {
            if (!Swimmers.Contains(aSwimmer))
                Swimmers.Add(aSwimmer);
            if(aSwimmer.Club == null)
                aSwimmer.Club = this;
            //else
                //throw new Exception();
        }

        public override string ToString() {
            string record = $"Name: {Name}\n" +
                $"Address: {ClubAddress}\n" +
                $"Phone: {PhoneNumber}\n" +
                $"Reg number: {ClubNumber}\n" +
                $"Swimmers: ";
            foreach (Registrant swimmer in Swimmers)
                record += $"\n\t{swimmer.Name}";
            record += $"\nCoach: {(Coach != null ? Coach.Name : "Not assigned")}";
            return record;
        }
    }
}
