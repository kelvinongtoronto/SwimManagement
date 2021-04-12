using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimManagementLibrary.classes
{
    public class Swim
    {
        public ushort Heat { get; set; }
        public byte Lane { get; set; }
        public DateTime Time { get; set; }

        public Swim()
        {
        }

        public Swim(ushort heat, byte lane)
        {
            Heat = heat;
            Lane = lane;
        }

        public override string ToString()
        {
            string swimInformation = $"H{Heat}L{Lane} time: ";
            // TODO: Format time to 00:00:00
            swimInformation += (Time != default) ? $"{Time}" : "no time";
            
            return swimInformation;
        }
    }
}
