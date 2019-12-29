Author: Hope Welch
Created: 12/24/19

This is the ScheduleManager (working title) application that allows people to easily see when their schedule match up
with others. 

Version 1.0.0 - Goal: Recieve input from a VS gui, Highlight when everyone has coinciding free time

Big Picture Goals by step:
VS gui, highlight when everyone has coinciding free time
Networking feature *program does more things*
Web feature
Transfer to phone app

Big Picture Questions:
When to implement database?


Notes!
When entering the start/end time, don't forget to add am or pm at the end


LOG:

12/24/19
I have decided to go about this project using MVC, and started with the Model.
The Model involves two projects: Schedule and Manager. 
Right now, only Schedule is set up and I am beginning implementation. 
Schedule:
	Each schedule object contains a dictionary of the days of the week and a list of events for each day.
	When a new event is created, it looks at the occurence property and adds it to the appropriate list in the dictionary.
	Reads input from a string**
Events: 
	Each event object contains properties that detail that event. For now, it just contains basic info
	like the name, start and end time, and the days of the week it occurs.

Current Questions:
**Will need to decide how to recieve input from the Manager. Use JSON? Multiple parameters?
What if there was a bool property for each day of the week?
Unit testing or console testing?

12/28/19
Deciding that it would be much easier if the event object had seven bool properties for each day of the week.
It would eliminate an extra string parse operation and make things simpler.

Testing. Unit testing takes some effort to set up and make sure you are correctly testing things. And while testing 
by printing everything onto the console is pretty easy but it's not very documenting... Lazy programmer side says console
and thorough CS student side says unit...
It can't hurt to set up a unit test project, and there is nothing stopping me from using the console for debugging.
Deciding to set up a unit test project for testing the Schedule class. This is going to help me determine how to 
recieve input from the Manager. 

Will I need to have a dictionary of users? I think that the database will take care of it, but it's a thought...
Actually, the Manager should have a list of users and their schedule objects for sure

Current Questions:
**Will need to decide how to recieve input from the Manager. Use JSON? Multiple parameters?

