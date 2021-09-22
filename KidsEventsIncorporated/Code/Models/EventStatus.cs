using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidsEventsIncorporated.Models
{
    /// <summary>
    /// Represents the status of the event
    /// </summary>
    public enum EventStatus
    {
        RegistrationOpen,
        RegistrationClosed,
        Started,
        Ended
    }
}