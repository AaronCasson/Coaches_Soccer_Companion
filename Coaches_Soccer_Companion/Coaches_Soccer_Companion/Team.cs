﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaches_Soccer_Companion
{
    class Team
    {
        public string TeamName;
        
        public Team(string teamname, Coach coach, List<Player> Players)
        {
            this.TeamName = teamname;
        }

    }
}