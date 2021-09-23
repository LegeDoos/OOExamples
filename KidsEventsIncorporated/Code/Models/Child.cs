using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidsEventsIncorporated.Models
{
    /// <summary>
    /// A kid that can participate in an event
    /// </summary>
    public class Child
    {
        public int ChildId { get; set; }
        /// <summary>
        /// Firstname of the kid
        /// </summary>
        public string Firstname { get; set; }
        /// <summary>
        /// Lastname of the kid
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Birthdate of the kid
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Events that the child is registered to
        /// </summary>
        public virtual ICollection<Event> EventsRegistered{ get; set; }
        /// <summary>
        /// Events that the kid was present
        /// </summary>
        public virtual ICollection<Event> EventsPresent { get; set; }
    }
}