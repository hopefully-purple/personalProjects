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
        public string eventName { get; set; }

        public int startTime { get; set; }

        public int endTime { get; set; }

        /// <summary>
        /// A string of the weekly occurence of this event.
        /// Foramtted "MWF" "THF" "SNST" "TW"
        /// </summary>
        public string weekOccurence { get; set; } 
        //TODO: Idea: What if there was a bool property for each day of the week?
    }
}
