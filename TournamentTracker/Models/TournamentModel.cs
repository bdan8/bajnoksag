using System;
using System.Collections.Generic;

namespace TournamentTracker
{
    public class TournamentModel
    {
        public EventHandler<bool> OnTournamentComplete;
        public int Id { get; set; }
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> teamModels { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
        public void CompleteTournament()
        {
            OnTournamentComplete?.Invoke(this, false);
        }
    }
}
