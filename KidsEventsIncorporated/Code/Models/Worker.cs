using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidsEventsIncorporated.Models
{
    /// <summary>
    /// represents a worker of the company. 
    /// </summary>
    public class Worker : User
    {
        /// <summary>
        /// Represents the list of events that the worker executes
        /// </summary>
        public virtual ICollection<Event> EventsExecuting { get; set; }

    }
}