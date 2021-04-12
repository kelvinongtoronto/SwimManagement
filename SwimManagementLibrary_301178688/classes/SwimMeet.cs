using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwimManagementLibrary.enums;

namespace SwimManagementLibrary.classes
{
    public class SwimMeet
    {
        // represents the pool type
        public PoolType Course { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte NoOfLanes { get; set; }
        public List<Event> Events { get; }
        public string Name { get; set; }

        public SwimMeet()
        {
            SetSwimMeet();
            Events = new List<Event>();
        }

        // constructor initializer
        private void SetSwimMeet(string name = "", DateTime start = default, DateTime end = default, PoolType course = PoolType.SCM, byte noOfLanes = 8 )
        {
            Name = name;
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            Course = course;
            NoOfLanes = noOfLanes;
        }

        public override string ToString()
        {
            string meetInformation = $"Swim Meet Name: {Name}\n" +
                $"From-to: {StartDate} to {EndDate}\n" +
                $"Pool Type: {Course}\n" +
                $"No Lanes: {NoOfLanes}\n" +
                $"Events:\n";

            foreach (Event anEvent in Events)
            {
                meetInformation += $"{anEvent}\n";
            }

            return meetInformation;
        }

        public void AddEvent(Event anEvent)
        {
            Events.Add(anEvent);
        }

        public void Seed()
        {
            foreach (Event anEvent in Events)
            {
                anEvent.Seed(NoOfLanes);
            }
        }
    }
}
