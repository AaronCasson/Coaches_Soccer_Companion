# Coaches_Soccer_Companion

Background:
This console app was designed and created by Aaron Casson to demonstrate concepts learned during the "Code Kentucky C# Development Course".  It meets the requirements of having multiple classes, and having objects of those classes populated with data.  It contains at least 3 method calls at least one of which returns a value that is ued in the application and contains at least 3 features: a master loop, inheritance, a list populated with values that are retrieved, data calculated based on an external factor (playtime start/end as provided by the user), and many other things learned during the course.

Inspiration:
During my time coaching my girls recreational soccer team one of my goals was to make sure that every player got roughly the same amount of time on the field.  Learning was more important than winning.  The trouble was that the number of girls who would show up to the game often changed, and there weren't enough girls to swap out every position every time, so I swapped out a few periodicly as time-outs allowed.  I tried to keep notes and tally the number of times each girl played, but this system was not great because it only told me how often they played, not how long.

Design:
This console application was designed to help recreational soccer coaches keep track of player's game time, and more specifically in this version I've focused on providing visability to which players have been on the bench the longest.  After "registering" by creating a coach and a team name, the coach can create a roster of players.  These players can then be assigned positions.  The coach can then start and stop the timer coinsiding with the referees calls.  Each time the app will report back who has been on the bench the longest and recommend they be moved to the field to play.  Play can then resume and the process repeats until the match ends at which point a full report is delivered.  For addtional details review comments in code.

Directions For Testing/Use:
- Enter a team name.
- Enter a coach first name.
- Enter a coach last name.
- Create several players by entering first name, last name, and birthdate
- Assign players to different positions (select bench for at least one so that you get to experience the focus of the current design)
- Start and stop the match by hitting the enter key
- Repeat the process several times - reassign players to different (or the same positions) and watch as the app recommends which player should get a chance to play next.
- End the match and review the list of position times for each player
- Restart or quit the app

Other Notes:
There are many potential features that could be added to an application like this - eg. summarizing total time played in all positions, tracking key stats about time spend in those positions (goals, saves, etc), as well as other technical improvements eg. UI, exporting/saving data, etc.  It is my hope to explore these opportuntites in the future.  The application was intentionally kept simple enough to complete during the time frame provided for the class.

Appreciate any feedback!

Enjoy!
