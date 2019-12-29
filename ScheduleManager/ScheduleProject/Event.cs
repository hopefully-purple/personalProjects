//Author: Hope Welch
//Created: 12/124/19
using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleProject
{
    /// <summary>
    /// Each event object contains properties that detail that event. For now, it just contains basic info
	/// like the name, start and end time, and the days of the week it occurs.
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Name of the owner
        /// </summary>
        public string ownerName { get; set; }

        /// <summary>
        /// Name of the event
        /// </summary>
        public string eventName { get; set; }

        /// <summary>
        /// Time of day the event starts
        /// TODO: Come up with a good way to represent time
        /// </summary>
        public string startTime { get; set; }  

        /// <summary>
        /// Time of day the event ends
        /// </summary>
        public string endTime { get; set; }

        /// <summary>
        /// True if this event occurs on a Monday
        /// </summary>
        public bool monday { get; set; }

        /// <summary>
        /// True if this event occurs on a Tuesday
        /// </summary>
        public bool tuesday { get; set; }

        /// <summary>
        /// True if this event occurs on a Wednesday
        /// </summary>
        public bool wednesday { get; set; }

        /// <summary>
        /// True if this event occurs on a Thursday
        /// </summary>
        public bool thursday { get; set; }

        /// <summary>
        /// True if this event occurs on a Friday
        /// </summary>
        public bool friday { get; set; }

        /// <summary>
        /// True if this event occurs on a Saturday
        /// </summary>
        public bool saturday { get; set; }

        /// <summary>
        /// True if this event occurs on a Sunday
        /// </summary>
        public bool sunday { get; set; }
    }
}
