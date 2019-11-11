using System.Collections.Generic;

namespace TournamentTracker
{
    public interface IDataConnection
    {
        void CreatePrize(PrizeModel model);
        void CreatePerson(PersonModel model);
        void CreateTeam(TeamModel model);
        void CreateTournament(TournamentModel model);
        void UpdateMatchup(MatchupModel model);
        void CompleteTournament(TournamentModel model);
        List<TournamentModel> GetTournament_All();
        List<TeamModel> GetTeam_All();
        List<PersonModel> GetPerson_All();
    }
}
