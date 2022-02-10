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
            TimeSpan x = playtimestart.Subtract(playtimeend);
            return x.TotalSeconds;
        }
    }

}