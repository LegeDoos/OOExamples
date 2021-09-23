using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        [Display(Name = "Event type")]
        public EventType EventType { get; set; }
        /// <summary>
        /// The description of the event
        /// </summary>
        [StringLength(500)]
        [Display(Name = "Description")]
        public string Description { get; set; }
        /// <summary>
        /// The planned start datetime of the event
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        [Display(Name = "Start of the event")]
        public DateTime StartDateTime { get; set; }
        /// <summary>
        /// The planned end datetime of the event
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        [Display(Name = "End of the event")]
        public DateTime EndDateTime { get; set; }
        /// <summary>
        /// The maximum number of participants for the event
        /// </summary>
        [Display(Name = "Maximum participants")]
        public int? MaxParticipants { get; set; }
        /// <summary>
        /// The minimum age of a participant
        /// </summary>
        [Display(Name = "Minimum age")]
        public int? MinumumAgeParticipants { get; set; }
        /// <summary>
        /// The maximum age of a participant
        /// </summary>
        [Display(Name = "Maximum age")]
        public int? MaximumAgeParticipants { get; set; }
        /// <summary>
        /// The status of the event (register/open/ended)
        /// </summary>
        [Required]
        [Display(Name = "Status")]
        public EventStatus Status { get; set; }
        /// <summary>
        /// The registered participants 
        /// </summary>
        public virtual ICollection<Child> Participants { get; set; }
        /// <summary>
        /// The actual present participants 
        /// </summary>
   //     public virtual ICollection<Child> ParticipantsPresent { get; set; }
        /// <summary>
        /// The workers that execute the event
        /// </summary>
        public virtual ICollection<Worker> EventExecutors { get; set; }
        /// <summary>
        /// The responsible organising professional worker of the event
        /// </summary>
        public virtual ProfessionalWorker OrganisingWorker { get; set; }
    }
}