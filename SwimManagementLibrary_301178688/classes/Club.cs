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
        public uint ClubNumber { get; private set; }
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

        public Club()
        {
            ClubNumber = RegistrationNumberGenerator.GetNext();
            if (Swimmers == null)
            {
                Swimmers = new List<Registrant>();
            }

        }

        public Club(string name, Address anAddress, ulong phoneNumber) : this()
        {
            ClubAddress = anAddress;
            Name = name;
            PhoneNumber = phoneNumber;

        }

        internal Club(uint regNumber, Address clubAddress, string name, ulong phoneNumber) : this(name, clubAddress, phoneNumber)
        {

            ClubNumber = regNumber;

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
