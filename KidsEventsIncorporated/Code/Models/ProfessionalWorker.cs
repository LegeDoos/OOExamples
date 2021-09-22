using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidsEventsIncorporated.Models
{
    /// <summary>
    /// Represents a professional worker of the company
    /// </summary>
    public class ProfessionalWorker : Worker
    {
        public virtual ICollection<Event> EventsOrganised { get; set; }

    }
}