using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaches_Soccer_Companion
{
    public enum Position
    {
        GoalKeeper,
        FullBack,
        MidFielder,
        Forward,
        Bench
    };

    class Playtime
    {
        public DateTime playtimestart;
        public DateTime playtimeend; 
        public Position position;
        public double playtime;
        
        public Playtime(Position position, double playtime)
        {
            this.position = position;
            this.playtime = playtime;
        }

       public double TimePlayed(DateTime playtimestart, DateTime playtimeend)
       {
           TimeSpan playtime = playtimeend.Subtract(playtimestart);
           return playtime.TotalSeconds;
       }


        public void CalculatePlaytime()
        {
            Console.WriteLine("Press \"Enter\" to start the match:");
            Console.ReadLine();
            DateTime playtimestart = DateTime.Now;
            Console.WriteLine("The game has started.  Press \"Enter\" again to pause the match:");
            Console.ReadLine();
            DateTime playtimeend = DateTime.Now;
            double newPlayTime = TimePlayed(playtimestart, playtimeend);
        }


            for (int index = 0; index < players.Count; index++)
            {
                players[index].playtimes.Add(newPlayTime);
            }
        }

    /* public double TimePlayed 
{ 
 get {
     TimeSpan playtime = playtimeend.Subtract(playtimestart);
     return playtime.TotalSeconds;
 }
}*/


    //timespan
    //position
    //in player class - it will have a list of playtime (a list of type playtime), playtimes, every time they play a diff position - you'd add to that playtime list.
    //first ask which player you want to add playtime to - need to find player in players list - list them out (use linq query), once you have that object player.add Playtime. player.playtimes.add (can call add on a list).
}

}