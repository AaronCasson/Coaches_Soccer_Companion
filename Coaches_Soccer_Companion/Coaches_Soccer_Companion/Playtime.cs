using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaches_Soccer_Companion
{

    class Playtime
    {
    public DateTime PlaytimeStart { get; set; }
    public DateTime PlaytimeEnd { get; set; } 
    public int goals { get; set; } 
    public int saves { get; set; }
        public static void Playtime(string playerID, string position, DateTime playtimeStart, DateTime playtimeEnd, int goals, int saves)
        {
            //????
        }
        
    
    // something to pull stats on the player???
    public static void PlayerStats()
        {
            double matchesAttended;
            double timePlayedTotal;
            double percentOfGamePlayed;
        }
}
