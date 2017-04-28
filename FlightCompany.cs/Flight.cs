using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// Represents a fligth available for the customers, so they can order tickets or make reservations for it.
    /// </summary>
    class Flight
    {
        private List<FlightObserver> _observers = new List<FlightObserver>();
        private List<Pilot> _pilots = new List<Pilot>();
        private List<Crew> _crewMembers = new List<Crew>();

        /// <summary>
        /// Number of the flight.
        /// </summary>
        public string Number { get; set; }
        
        /// <summary>
        /// Date and time of flight's departure from the origin.
        /// </summary>
        public DateTime Departure { get; set; }
        
        /// <summary>
        /// Date and time of flight's arrival at the destination.
        /// </summary>
        public DateTime Arrival { get; set; }

        /// <summary>
        /// Types of the flight (i.e. Overnight, Express, Internation, National)
        /// </summary>
        public List<FlightType> FlightTypes { get; set; }
        
        /// <summary>
        /// The plane conducting this flight.
        /// </summary>
        public Plane plane { get; set; }
        
        /// <summary>
        /// The path that the flight comprehends, from origin to destination.
        /// </summary>
        public Route route { get; set; }

        /// <summary>
        /// Adds a new pilot to the flight.
        /// </summary>
        /// <param name="pilot">The pilot to be added.</param>
        public void AddPilot(Pilot pilot)
        {
            _pilots.Add(pilot);
        }

        /// <summary>
        /// Returns the pilots from the flight.
        /// </summary>
        public List<Pilot> GetPilots()
        {
            return _pilots;
        }

        /// <summary>
        /// Adds a new crew member to the flight.
        /// </summary>
        /// <param name="pilot">The crew member to be added.</param>
        public void AddCrewMember(Crew crew)
        {
            _crewMembers.Add(crew);
        }

        /// <summary>
        /// Returns the crew members from the flight.
        /// </summary>
        public List<Crew> GetCrewMembers()
        {
            return _crewMembers;
        }

        /// <summary>
        /// Creates a new flight. The parameters are the input for the flight properties.
        /// </summary>
        /// <returns>Returns a new flight.</returns>
        public Flight CreateFlight(string number, DateTime departure, DateTime arrival, Plane plane, Route route, Pilot pilot)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cancel the flight.
        /// </summary>
        public void Cancel()
        {
            
        }

        /// <summary>
        /// Allows a observer to be attached to the flight and receive notifications.
        /// </summary>
        /// <param name="observer">The observer to be added.</param>
        public void Attach(FlightObserver observer)
        {
           _observers.Add(observer); 
        }

        /// <summary>
        /// Allows the observer to stop receiving notifications from flight.
        /// </summary>
        /// <param name="observer">The observer to be detached.</param>
        public void Detach(FlightObserver observer)
        {
            _observers.Remove(observer);
        }

        /// <summary>
        /// Let all observers be notified that the has been updated.
        /// </summary>
        public void Notify()
        {
            foreach (FlightObserver observer in _observers)
            {
                observer.Update(this);
            }
        }







    }
}
