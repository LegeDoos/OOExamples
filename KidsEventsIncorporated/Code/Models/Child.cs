using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        [StringLength(50)]
        [Display(Name = "First name")]
        public string Firstname { get; set; }
        /// <summary>
        /// Lastname of the kid
        /// </summary>
        [StringLength(50)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        /// <summary>
        /// Birthdate of the kid
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birth date")]
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