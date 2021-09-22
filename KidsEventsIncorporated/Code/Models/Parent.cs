using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidsEventsIncorporated.Models
{
    /// <summary>
    /// The parent of a kid that can participate to a event. The parent can login to the system
    /// </summary>
    public class Parent : User
    {
        /// <summary>
        /// The kids of the parent
        /// </summary>
        public virtual ICollection<Child> Children { get; set; }
    }
}