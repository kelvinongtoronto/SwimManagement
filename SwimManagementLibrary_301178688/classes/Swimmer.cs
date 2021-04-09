using SwimManagementLibrary.structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimManagementLibrary.classes
{
    public class Swimmer : Registrant
    {
        public new Club Club
        {
            get {
                return club;
            }
            set {
                if (club == null)
                {
                    club = value;
                    if (value != null)
                        value.AddSwimmer(this);
                }
                else
                {
                    throw new Exception("Swimmer is registered with a different club");
                }
            }
        }

        public Swimmer() {

        }

        public Swimmer(string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber) :
            base(name,dateOfBirth,anAddress,phoneNumber) {
            
        }

        internal Swimmer(uint regNumber, string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber) :
            base(regNumber,name,dateOfBirth,anAddress,phoneNumber) {

        }
    }
}
