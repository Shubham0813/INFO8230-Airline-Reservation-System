using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    class Flight
    {
        private List<FlightObserver> _observers = new List<FlightObserver>();
        private List<Pilot> _pilots = new List<Pilot>();
        private List<Crew> _crewMembers = new List<Crew>();

        public string Number { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public FlightType FlightType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Plane plane { get; set; }
        public Route route { get; set; }

        public void AddPilot(Pilot pilot)
        {
            _pilots.Add(pilot);
        }

        public List<Pilot> GetPilots()
        {
            return _pilots;
        }

        public void AddCrewMember(Crew crew)
        {
            _crewMembers.Add(crew);
        }

        public List<Crew> GetCrewMembers()
        {
            return _crewMembers;
        }

        public void CreateFlight()
        {
            
        }

        public void Cancel()
        {
            
        }

        public void Attach(FlightObserver observer)
        {
           _observers.Add(observer); 
        }

        public void Detach(FlightObserver observer)
        {
            _observers.Remove(observer);
        }


        public void Notify()
        {
            foreach (FlightObserver observer in _observers)
            {
                observer.Update(this);
            }
        }







    }
}
