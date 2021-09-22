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

        //todo: id's met afgeleide classes
        //todo: fk's indien ik andere naam wil
        //todo: handleiding afmaken: https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application
    }
}