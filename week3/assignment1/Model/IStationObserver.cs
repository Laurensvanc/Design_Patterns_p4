﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Model
{
    public interface IStationObserver
    {
        void Update(TrainStation station);
    }
}