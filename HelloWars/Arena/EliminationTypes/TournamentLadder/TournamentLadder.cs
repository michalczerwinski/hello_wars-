﻿using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Arena.Configuration;
using Arena.Interfaces;
using Arena.Models;

namespace Arena.EliminationTypes.TournamentLadder
{
    public class TournamentLadder: IElimination
    {
        public List<string> Competitors { get; set; }

        public UserControl GetVisualization(List<Competitor> competitors)
        {
            return new TournamentLadderControl(competitors);
        }

        public IList<CompetitorUrl> GetNextCompetitors(CompetitorUrl lastWinner)
        {
            throw new NotImplementedException();
        }
    }
}
