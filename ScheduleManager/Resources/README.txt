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