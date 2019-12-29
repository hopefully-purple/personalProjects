//Author: Hope Welch
//Created: 12/28/19
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScheduleProject;

namespace ScheduleProjectUnitTest
{
    [TestClass]
    public class ScheduleTests
    {
        private Dictionary<String, List<Event>> scheduleDict;

        //******************************Basic Functionality**********************

        [TestMethod]
        public void CreateAnEmptyScheduleObject() //TODO: Arg, come back to this
        {
            scheduleDict = new Dictionary<string, List<Event>>();

            scheduleDict.Add("Sunday", new List<Event>());
            scheduleDict.Add("Monday", new List<Event>());
            scheduleDict.Add("Tuesday", new List<Event>());
            scheduleDict.Add("Wednesday", new List<Event>());
            scheduleDict.Add("Thursday", new List<Event>());
            scheduleDict.Add("Friday", new List<Event>());
            scheduleDict.Add("Saturday", new List<Event>());

            Schedule s = new Schedule();

            Assert.AreEqual(scheduleDict, s.GetSchedule());
        }

        [TestMethod]
        public void AddEvent() 
        {
            Schedule s = new Schedule();
            //Right now, deciding to enter information with multiple parameters
            s.AddEvent("Hope", "CS3505", "2:15pm", "3:40pm", "M W F"); //TODO:BookMark 12/28/19

        }
    }
}
