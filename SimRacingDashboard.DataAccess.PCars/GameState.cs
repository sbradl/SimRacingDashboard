﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimRacingDashboard.DataAccess.PCars
{
    enum GameState : byte
    {
        Exited = 0,
        FrontEnd,
        Playing,
        Paused
    }
}
