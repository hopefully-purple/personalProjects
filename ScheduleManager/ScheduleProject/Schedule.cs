//Author: Hope Welch
//Created: 12/24/19
using System;
using System.Collections.Generic;

namespace ScheduleProject
{
    /// <summary>
    /// Each schedule object contains a dictionary of the days of the week and a list of events for each day.
	/// When a new event is created, it looks at the occurence property and adds it to the appropriate list in the dictionary.
	/// Reads input from a string**
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// Dictionary containing this object's schedule. the Keys are the days of the week and the value
        /// is a list of events for the corresponding day
        /// </summary>
        private Dictionary<String, List<Event>> scheduleDict;

        /// <summary>
        /// Schedule constructor
        /// </summary>
        public Schedule()
        {
            scheduleDict = new Dictionary<string, List<Event>>();

            scheduleDict.Add("Sunday", new List<Event>());
            scheduleDict.Add("Monday", new List<Event>());
            scheduleDict.Add("Tuesday", new List<Event>());
            scheduleDict.Add("Wednesday", new List<Event>());
            scheduleDict.Add("Thursday", new List<Event>());
            scheduleDict.Add("Friday", new List<Event>());
            scheduleDict.Add("Saturday", new List<Event>());
        }

        /// <summary>
        /// Creates an event and adds it to the dictionary
        /// </summary>
        /// <param name="events"></param>
        public void AddEvent(string events)
        {

        }
    }
}
