﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SharedTrip.ViewModels.Trips
{
    public class HomePageTripViewModel
    {
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public string Departuretime { get; set; }
        public int Seats { get; set; }
    }
}
