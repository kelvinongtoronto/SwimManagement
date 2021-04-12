using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwimManagementLibrary.interfaces;
using SwimManagementLibrary.structs;

namespace SwimManagementLibrary.classes
{
    public class SwimmersManager : ISwimmersRepository
    {
        public IClubsRepository ClubsManager { get; set; }
        public List<Swimmer> Swimmers { get; }

        public SwimmersManager(IClubsRepository manager) {
            ClubsManager = manager;
            Swimmers = new List<Swimmer>();
        }

        public void AddSwimmer(Swimmer aSwimmer) {
            Swimmers.Add(aSwimmer);
        }

        private string formatRecord(Registrant aSwimmer, string delimiter) {
            if (aSwimmer.Club != null)
                return $"{aSwimmer.Id}{delimiter}" +
                    $"{aSwimmer.Name}{delimiter}" +
                    $"{aSwimmer.DateOfBirth}{delimiter}" +
                    $"{aSwimmer.Address.Street}{delimiter}" +
                    $"{aSwimmer.Address.City}{delimiter}" +
                    $"{aSwimmer.Address.Province}{delimiter}" +
                    $"{aSwimmer.Address.PostalCode}{delimiter}" +
                    $"{aSwimmer.PhoneNumber}{delimiter}" +
                    $"{aSwimmer.Club.ClubNumber}";
            else
                return $"{aSwimmer.Id}{delimiter}" +
                    $"{aSwimmer.Name}{delimiter}" +
                    $"{aSwimmer.DateOfBirth}{delimiter}" +
                    $"{aSwimmer.Address.Street}{delimiter}" +
                    $"{aSwimmer.Address.City}{delimiter}" +
                    $"{aSwimmer.Address.Province}{delimiter}" +
                    $"{aSwimmer.Address.PostalCode}{delimiter}" +
                    $"{aSwimmer.PhoneNumber}{delimiter}";
        }

        public Swimmer GetSwimmer(uint regNumber) {
            foreach(Swimmer swimmer in Swimmers)
            {
                if (swimmer.Id == regNumber)
                    return swimmer;
            }
            return null;
        }

        public void LoadSwimmers(string fileName, string delimiter) {
            string swimmerRecord;
            try
            {
                using (StreamReader file = new StreamReader(fileName))
                {
                    while (!file.EndOfStream)
                    {
                        swimmerRecord = file.ReadLine();
                        try
                        {
                            Swimmers.Add(processSwimmerRecord(swimmerRecord, delimiter));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                throw new Exception($"File {fileName} not found");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Swimmer processSwimmerRecord(string aRecord, string delimiter) {
            string[] swimmerInfo = aRecord.Split(delimiter[0]);
            if (swimmerInfo.Length < 9)
                throw new Exception($"Invalid swimmer record. Not enough fields\n\t{aRecord}");

            string street = swimmerInfo[3];
            string city = swimmerInfo[4];
            string prov = swimmerInfo[5];
            string postCode = swimmerInfo[6];
            Address address = new Address(street, city, prov, postCode);

            uint id;
            string name;
            DateTime dob;
            ulong phone;
            uint clubRegNum;

            try
            {
                id = UInt32.Parse(swimmerInfo[0]);
            }
            catch (FormatException)
            {
                throw new Exception($"Invalid swimmer record. Invalid registration number\n\t{aRecord}");
            }

            name = swimmerInfo[1];
            if (name.Length == 0)
            {
                throw new Exception($"Invalid swimmer record. Invalid swimmer name\n\t{aRecord}");
            }

            try
            {
                dob = DateTime.Parse(swimmerInfo[2]);
            }
            catch (FormatException)
            {
                throw new Exception($"Invalid swimmer record. Birth date is invalid\n\t{aRecord}");
            }

            try
            {
                phone = UInt64.Parse(swimmerInfo[7]);
            }
            catch (FormatException)
            {
                throw new Exception($"Invalid swimmer record. Phone number wrong format\n\t{aRecord}");
            }

            if (GetSwimmer(id) != null)
            {
                throw new Exception($"Invalid swimmer record. Swimmer with the registration number already exists\n\t{aRecord}");
            }

            Club theClub;
            if (swimmerInfo[8] != "")
            {
                clubRegNum = UInt32.Parse(swimmerInfo[8]);
                theClub = ClubsManager.GetClub(clubRegNum);

                if (theClub == null)
                    throw new Exception($"Invalid swimmer record. Club affiliation exists but not valid\n\t{aRecord}");
            }
            else 
            {
                theClub = null;
            }

            Swimmer newSwimmer = new Swimmer(id, name, dob, address, phone)
            {
                Club = theClub
            };

            return newSwimmer;
        }

        public void SaveSwimmers(string fileName, string delimiter) {
            try
            {
                using (TextWriter file = new StreamWriter(fileName))
                {
                    foreach (Swimmer swimmer in Swimmers)
                    {
                        file.WriteLine(formatRecord(swimmer, delimiter));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                throw new Exception($"File {fileName} not found");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
