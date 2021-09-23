using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidsEventsIncorporated.Models
{
    /// <summary>
    /// The event
    /// </summary>
    public class Event
    {
        public int EventID { get; set; }
        /// <summary>
        /// The type of the event
        /// </summary>
        public EventType EventType { get; set; }
        /// <summary>
        /// The description of the event
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The planned start datetime of the event
        /// </summary>
        public DateTime StartDateTime { get; set; }
        /// <summary>
        /// The planned end datetime of the event
        /// </summary>
        public DateTime EndDateTime { get; set; }
        /// <summary>
        /// The maximum number of participants for the event
        /// </summary>
        public int? MaxParticipants { get; set; }
        /// <summary>
        /// The minimum age of a participant
        /// </summary>
        public int? MinumumAgeParticipants { get; set; }
        /// <summary>
        /// The maximum age of a participant
        /// </summary>
        public int? MiximumAgeParticipants { get; set; }
        /// <summary>
        /// The status of the event (register/open/ended)
        /// </summary>
        public EventStatus Status { get; set; }
        /// <summary>
        /// The registered participants 
        /// </summary>
    //    public virtual ICollection<Child> RegisteredParticipants { get; set; }
        /// <summary>
        /// The actual present participants 
        /// </summary>
   //     public virtual ICollection<Child> PresentParticipants { get; set; }
        /// <summary>
        /// The workers that execute the event
        /// </summary>
   //     public virtual ICollection<Worker> EventExecutors { get; set; }
        /// <summary>
        /// The responsible organising professional worker of the event
        /// </summary>
     //   public virtual ProfessionalWorker OrganisingWorker { get; set; }
    }
}