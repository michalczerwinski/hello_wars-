﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotClient;

namespace Arena.Models
{
    public class DuelPair
    {
        public Competitor Competitor1 { get; set; }
        public Competitor Competitor2 { get; set; }
        //public bool IsCompetitor1Win { get; set; }
        //public bool IsCompetitor2Win { get { return !IsCompetitor1Win; } }
        
    }
}
