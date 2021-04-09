using SwimManagementLibrary.classes;
using System.Collections.Generic;

namespace SwimManagementLibrary.interfaces
{
    public interface IClubsRepository
    {
        List<Club> Clubs { get; }
        void AddClub(Club aClub);
        Club GetClub(uint clubRegNum);
        void LoadClubs(string fileName, string demiliter);
        void SaveClubs(string fileName, string delimiter);
    }
}