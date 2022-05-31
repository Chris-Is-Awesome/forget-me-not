# Forget me Not!
Reminders, notes, to-do list, anything to help keep your life organized!

# Features
- Create reminders
- Reminders notify you at the given time
- Edit & delete functionality for each reminder
- Program runs in background and constantly monitors for reminder times
- Notification is fired when its time is met
- Reminders can be snoozed
- Reminders get deleted when marked as done
- Reminder notification plays a ringtone
- Custom context menu in notification tray has option to close program, useful for when it's running in background

## Usage
Download and extract `ForgetMeNot.zip` from the latest release from [releases page](https://github.com/Chris-Is-Awesome/forget-me-not/releases) and run `ForgetMeNot.exe`

## Technologies Used
- .NET
- SQLite
- Visual Studio Designer

## Libraries Used
- [Simple Audio Player](https://github.com/adrianstevens/Xamarin-Plugins/tree/main/SimpleAudioPlayer)

## Known Issues
- Having reminder selected when its notification fires, then clicking "mark as done" keeps the deleted reminder's details view up, allowing user to edit deleted reminder's details, causing null refs
- In rare cases, notification doesn't show on top of certain programs (eg. YouTube video). This is not consistent behavior it seems

## References
- Main window restoring to original state from minimized state - [Mesmo](https://stackoverflow.com/a/2725234)

## Log
View full log of edits [here](Log.md)