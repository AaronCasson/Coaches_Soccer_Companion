using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaches_Soccer_Companion
{

    class Playtime
    {
        public static DateTime playtimestart;
        public static DateTime playtimeend;

        public double TimePlayed(DateTime playtimestart, DateTime playtimeend)
        {
            TimeSpan playtime = playtimeend.Subtract(playtimestart);
            return playtime.TotalSeconds;
        }

        public enum Position
        {
            GoalKeeper,
            FullBack,
            MidFielder,
            Forward,
            Bench
        };
        //timespan
        //position
        //in player class - it will have a list of playtime (a list of type playtime), playtimes, every time they play a diff position - you'd add to that playtime list.
        //first ask which player you want to add playtime to - need to find player in players list - list them out (use linq query), once you have that object player.add Playtime. player.playtimes.add (can call add on a list).
    }

}