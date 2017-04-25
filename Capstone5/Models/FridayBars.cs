﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Capstone5.Models
{
    public class FridayBars
    {
        [Key]

        public int BarsID { get; set; }

        public string BarName { get; set; }

        public string Specials { get; set; }

        public int DaytimeBusyness { get; set; }

        public int EveningBusyness { get; set; }

        public int NightTimeBusyness { get; set; }

        public string AdditionalFeatures { get; set; }

    }
}