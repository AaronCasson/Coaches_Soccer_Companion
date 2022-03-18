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

    class PositionTime
    {
        public DateTime PlaytimeStart;
        public DateTime PlaytimeEnd;
        public Position Position;
        public double TimePlayed;
        


        public static double TimePlayedCalc(DateTime PlaytimeStart, DateTime PlaytimeEnd)
            {
                TimeSpan playtime = PlaytimeEnd.Subtract(PlaytimeStart);
                return playtime.TotalSeconds;
            }
        
    }
}