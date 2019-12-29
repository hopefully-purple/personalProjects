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
        /// Getter for this dictionary
        /// </summary>
        /// <returns></returns>
        public Dictionary<String, List<Event>> GetSchedule()
        {
            return scheduleDict;
        }

        /// <summary>
        /// Creates an event and adds it to the dictionary
        /// </summary>
        /// <param name="events"></param>
        public void AddEvent(string owner, string name, string start, string end, string occur)
        {
            //Create a new event object and set the string properties
            Event newE = new Event();
            newE.ownerName = owner;
            newE.eventName = name;
            newE.startTime = start;
            newE.endTime = end;

            //Parse the occur parameter
            string[] occurList = occur.Split(' ');

            //Switch case? for loop? While loop? TODO:BookMark 12/28/19
            

        }
    }
}
