using SwimManagementLibrary.classes;
using System.Collections.Generic;

namespace SwimManagementLibrary.interfaces
{
    public interface ISwimmersRepository
    {
        IClubsRepository ClubsManager { get; set; }
        List<Swimmer> Swimmers { get; }
        void AddSwimmer(Swimmer aSwimmer);
        Swimmer GetSwimmer(uint regNumber);
        void LoadSwimmers(string fileName, string delimiter);
        void SaveSwimmers(string fileName, string delimiter);
    }
}