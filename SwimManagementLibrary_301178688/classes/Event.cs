using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwimManagementLibrary.enums;

namespace SwimManagementLibrary.classes
{
    public class Event
    {
        private Dictionary<Registrant,Swim> swimmingEvents;

        public EventDistance Distance { get; set; }
        public Stroke Stroke { get; set; }
        public List<Registrant> Swimmers { 
            get
            {
                return new List<Registrant>(swimmingEvents.Keys);
            }
        }

        public Event()
        {
            swimmingEvents = new Dictionary<Registrant, Swim>();
        }
        
        public Event(EventDistance distance, Stroke stroke):this()
        {
            Distance = distance;
            Stroke = stroke;
          
        }

        public override string ToString()
        {
            string eventInformation;

            eventInformation = $"\n\t{Distance} {Stroke}\n\tSwimmers:";

            foreach (Registrant swimmer in Swimmers)
            {
                try
                {
                    bool swimmerSwimFound = swimmingEvents.TryGetValue(swimmer, out Swim swimmerSwim);
                    if (!swimmerSwimFound)
                    {
                        eventInformation += $"\n\t{swimmer.Name}\n\t\tNot seeded/no swim.";
                    }
                    else
                    {
                        eventInformation += $"\n\t{swimmer.Name}\n\t\t{swimmerSwim}.";
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return eventInformation;
        }

        public void AddSwimmer(Registrant aSwimmer)
        {
            // check if swimmer is already on the event
            if (swimmingEvents.ContainsKey(aSwimmer))
            {
                throw new Exception($"Swimmer {aSwimmer.Name}, {aSwimmer.Id} is already entered.");
            }
            else
            {
                // add to the Registrants swim
                swimmingEvents[aSwimmer] = null;
            }
        }

        public void EnterSwimmersTime(Registrant aSwimmer, string time)
        {
            Swim swimmersSwim = swimmingEvents[aSwimmer];
            DateTime formattedTime = default;

            try
            {
                // update the swimmers time
                //formattedTime = DateTime.Parse(time);
                formattedTime = DateTime.ParseExact(time, "mm:ss.FF", System.Globalization.CultureInfo.InvariantCulture);
                swimmersSwim.Time = formattedTime;
                swimmingEvents[aSwimmer] = swimmersSwim;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Seed(byte maxLanes)
        {
            try
            {
                int maxNumberOfLanes = Convert.ToInt32(maxLanes);
                int heatCounter = 1;
                int laneCounter = 1;   
                foreach (Registrant aSwimmer in Swimmers)
                {
                    ushort swimmerHeat = Convert.ToUInt16(heatCounter);
                    byte swimmerLane = Convert.ToByte(laneCounter);

                    Swim swimmersSeed = new Swim(swimmerHeat, swimmerLane);
                    swimmingEvents[aSwimmer] = swimmersSeed;

                    if (laneCounter == maxNumberOfLanes)
                    {
                        heatCounter++;
                        laneCounter = 1;
                        continue;
                    }

                    laneCounter++;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        //private class RegistrantsSwims
        //{
        //    public List<Registrant> swimmers;
        //    //public List<Registrant> Swimmers { get; }
        //    public List<Swim> swims;

        //    public void AddOrUpdate(Registrant swimmer, Swim swim)
        //    {
        //        if (Contains(swimmer))
        //        {
        //            // update swimmers swim
        //            int swimmerIndex = swimmers.FindIndex(aSwimmer => aSwimmer.Id == swimmer.Id);
        //            swims[swimmerIndex] = swim;
        //        }
        //        else
        //        {
        //            // add the swimmer
        //            swimmers.Add(swimmer);

        //            // add a blank swim on swims
        //            swims.Add(swim);
        //        }
        //    }

        //    public bool Contains(Registrant swimmer)
        //    {
        //        // check if the swimmer is already in the list
        //        return swimmers.Any(aSwimmer => aSwimmer.Id == swimmer.Id);
        //    }

        //    public Swim GetSwimmersSwim(Registrant swimmer)
        //    {
        //        if (Contains(swimmer))
        //        {
        //            int swimmerIndex = swimmers.FindIndex(aSwimmer => aSwimmer.Id == swimmer.Id);
        //            return swims[swimmerIndex];
        //        }
        //        else
        //        {
        //            throw new Exception("Swimmer has not entered event");
        //        }
        //    }
        //}
    }
}
