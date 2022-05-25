## Log

### Week 1
| Day                 | Start Time | End Time | Task(s)                                                 |
|---------------------|------------|----------|---------------------------------------------------------|
| Monday, 1/10/22     | 9:30       | 10:00    | Troubleshoot project creation & gitignore |
| Monday, 1/10/22     | 10:00      | 10:50    | Some cleanup & code setup; hook first button to Reminder class
| Monday, 1/10/22     | 10:50      | 12:00    | Show create reminder group when reminder button clicked; experimented with date/time inputs
| Tuesday, 1/11/22    | 10:20      | 11:50    | Add functionality to the "remind me in..." buttons to update the reminder time with the set intervals
| Tuesday, 1/11/22    | 11:50      | 1:30     | Attempt to prevent user from setting reminder time to a past time, unfinished, need to learn more about how additional forms work
| Thursday, 1/13/22   | 9:20       | 9:55     | Create reminders using data from form and store them in a list
| Thursday, 1/13/22   | 10:00      | 12:00    | Form/code cleanup, Add popups for form validation/error handling; formatting improvements

### Week 2
| Day                 | Start Time | End Time | Task(s)                                                 |
|---------------------|------------|----------|---------------------------------------------------------|
| Wednesday, 3/2/22   | 2:00       | 4:00     | Research databases and the best way to handle them
| Thursday, 3/3/22    | 9:00       | 12:00    | Continued research from yesterday & start practice project with SQLite
| Friday, 3/4/22      | 1:00       | 4:00     | Continued practice project with SQLite and looked into potential libraries to use

*This is after the final section*

### Week 3
| Day                 | Start Time | End Time | Task(s)                                                 |
|---------------------|------------|----------|---------------------------------------------------------|
| Monday, 4/18/22     | 9:30       | 10:00    | Install & configure VS 2022 since it has some features I'll need, and I want to be up to date anyways.
| Monday, 4/18/22     | 10:00      | 11:00    | Minor cleanup; get a better understanding of using VS debug & diagnostic tools. Very cool! (https://youtu.be/sACkw915kmg)
| Monday, 4/18/22     | 11:00      | 12:00    | Planning on form layout & how to implement SQLite
| Tuesday, 4/19/22    | 9:15       | 12:00    | Continue looking into how to implement database stuff... I think I might finally be onto something (https://www.youtube.com/watch?v=wvFC_60FR7c & https://www.youtube.com/watch?v=d6BTfwmK-S4)
| Wednesday, 4/20/22  | 1:30       | 2:00     | Got loading data from SQL database working! More SQL stuff needed, but want to work on somme design first so I can more easily test things.
| Wednesday, 4/20/22  | 2:00       | 4:00     | Did more planning & work on the layout of the program.
| Thursday, 4/21/22   | 9:20       | 10:30    | Successfully fill some visual elements with data from database, not exactly how I want it though, so needs more work.
| Thursday, 4/21/22   | 10:30      | 12:00    | Play around with front end to get database viewing more how I want, still far from where I want it, but getting there.
| Friday, 4/22/22     | 9:15       | 1:30     | Ugh. Got reminders going to the list I want, was pain and agony... VS SQL support sucks, don't use it.

### Week 4
| Day                | Start Time | End Time | Task(s)                                                  |
|--------------------|------------|----------|----------------------------------------------------------|
| Monday, 4/25/22    | 1:00       | 2:00     | Update front end to add right panel to show either create reminder or reminder details.
| Monday, 4/25/22    | 2:00       | 4:00     | Merged big PR; show more reminder details when reminder button is clicked. VS form designer is bad, don't use it.
| Tuesday, 4/26/22   | 9:15       | 11:00    | Organize file structure, minor code cleanup with singletons, fix annoying VS issue
| Tuesday, 4/26/22   | 11:00      | 12:20    | Organize readme(s) & learn more markdown tricks - rewrote what you're reading now!
| Wednesday, 4/27/22 | 9:40       | 11:30    | Tried adding data to database, but VS is shit and doesn't support that, so gotta restart project :)
| Thursday, 4/28/22  | 9:10       | 12:00    | Troubleshooting with VS database stuff
| Friday, 4/29/22    | 9:15       | 12:00    | Cleanup database code & attempt to set up edit/delete functionality

### Week 5
| Day                | Start Time | End Time | Task(s)                                                  |
|--------------------|------------|----------|----------------------------------------------------------|
| Monday, 5/2/22     | 9:45       | 12:00    | Troubleshoot why edit/delete functionality isn't working
| Tuesday, 5/3/22    | 9:10       | 11:50    | Scrapped edit/delete functionality and started it from scratch, successfully got delete functionality working, added debug handler for improved error handling, and some minor code cleanup
| Wednesday, 5/4/22  | 1:30       | 1:45     | Add update functionality to database handler
| Wednesday, 5/4/22  | 1:45       | 4:00     | Start brainstorming/implementing a edit form for reminders
| Thursday, 5/5/22   | 10:00      | 12:00    | Added edit functionality? Doesn't quite work how I expected it to yet; needs fixing. Fixed issue with duplicate IDs
| Friday, 5/6/22     | 9:15       | 12:00    | Troubleshooting galore...

### Week 6
| Day                | Start Time | End Time | Task(s)                                                  |
|--------------------|------------|----------|----------------------------------------------------------|
| Monday, 5/9/22     | 9:00       | 11:00    | Refactor to use GUID, got edit functionality working, added CreatedAt column to database to allow filtering reminders by time created, some minor bug fixing
| Tuesday, 5/10/22   | 9:00       | 10:00    | Think of what to do next, lots of testing to ensure things are working before moving on
| Tuesday, 5/10/22   | 10:00      | 10:30    | Final known bug fixes (for now)
| Wednesday, 5/11/22 | 9:00       | 9:30     | Show reminder details when reminder clicked, convert stored times to UTC
| Wednesday, 5/11/22 | 9:30       | 11:00    | Look into how notifications work, will have to create a custom form to popup as a notification since system notifications don't support custom buttons
| Thursday, 5/12/22  | 9:15       | 12:00    | More of the above & start process of creating notification form
| Friday, 5/13/22    | 9:00       | 11:30    | Created notification form & started work on making it functional

### Week 7
| Day                | Start Time | End Time | Task(s)                                                  |
|--------------------|------------|----------|----------------------------------------------------------|
| Wednesday, 5/18/22 | 9:40       | 11:45    | Planning next steps & start implementing reminder repeatability
| Thursday, 5/19/22  | 1:00       | 3:45     | Push repeatability off to stretch goals and look into how to have a timer for notifications
| Friday, 5/20/22    | 9:00       | 12:15    | Fire notifications at reminder time! HUGE progress! Fixed some issues with UTC time conversion too

### Week 8
| Day                | Start Time | End Time | Task(s)                                                  |
|--------------------|------------|----------|----------------------------------------------------------|
| Monday, 5/23/22    | 1:00       | 2:00     | Render notification popup over everything else
| Monday, 5/23/22    | 2:00       | 3:15     | Run in background, minimize & re-open properly, custom context menu for notification tray icon
| Monday, 5/23/22    | 3:15       | 4:00     | Start implementing mark as done and snooze functionalites
| Tuesday, 5/24/22   | 9:15       | 12:00    | Got distracted by a shiny feature that didn't work out
| Wednesday, 5/25/22 | 9:00       | 10:00    | Added mark as done functionality
