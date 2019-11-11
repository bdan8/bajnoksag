using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

namespace TournamentTracker
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "Tournaments";

        public void CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var person = new DynamicParameters();

                person.Add("@FirstName", model.FirstName);
                person.Add("@LastName", model.LastName);
                person.Add("@EmailAddress", model.EmailAddress);
                person.Add("@CellPhoneNumber", model.CellPhoneNumber);
                person.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", person, commandType: CommandType.StoredProcedure);

                model.Id = person.Get<int>("@id");
            }
        }

        public void CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var prize = new DynamicParameters();

                prize.Add("@PlaceNumber", model.PlaceNumber);
                prize.Add("@PlaceName", model.PlaceName);
                prize.Add("@PrizeAmount", model.PrizeAmount);
                prize.Add("@PrizePercentage", model.PrizePercentage);
                prize.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", prize, commandType: CommandType.StoredProcedure);

                model.Id = prize.Get<int>("@id");
            }
        }

        public void CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var team = new DynamicParameters();

                team.Add("@TeamName", model.TeamName);
                team.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeam_Insert", team, commandType: CommandType.StoredProcedure);

                model.Id = team.Get<int>("@id");

                foreach (PersonModel teamMember in model.TeamMembers)
                {
                    team = new DynamicParameters();

                    team.Add("@TeamId", model.Id);
                    team.Add("@PersonId", teamMember.Id);

                    connection.Execute("dbo.spTeamMembers_Insert", team, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public void CreateTournament(TournamentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                SaveTournament(connection, model);
                SaveTournamentPrizes(connection, model);
                SaveTournamentEntries(connection, model);
                SaveTournamentRounds(connection, model);
                TournamentLogic.UpdateTournamentResults(model);
            }
        }

        public void SaveTournamentRounds(IDbConnection connection, TournamentModel model)
        {
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    var p = new DynamicParameters();

                    p.Add("@MatchupRound", matchup.MatchupRound);
                    p.Add("@TournamentId", model.Id);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spMatchups_Insert", p, commandType: CommandType.StoredProcedure);

                    matchup.Id = p.Get<int>("@id");

                    foreach (MatchupEntryModel entry in matchup.Entries)
                    {
                        p = new DynamicParameters();

                        p.Add("@MatchupId", matchup.Id);
                        if (entry.ParentMatchup == null)
                        {
                            p.Add("@ParentMatchupId", null);
                        }
                        else
                        {
                            p.Add("@ParentMatchupId", entry.ParentMatchup.Id);
                        }
                        if (entry.TeamCompeting == null)
                        {
                            p.Add("@TeamCompetingId", null);
                        }
                        else
                        {
                            p.Add("@TeamCompetingId", entry.TeamCompeting.Id);
                        }
                        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                        connection.Execute("dbo.spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);

                    }
                }
            }
        }

        private void SaveTournament(IDbConnection connection, TournamentModel model)
        {
            var tournament = new DynamicParameters();

            tournament.Add("@TournamentName", model.TournamentName);
            tournament.Add("@EntryFee", model.EntryFee);
            tournament.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournaments_Insert", tournament, commandType: CommandType.StoredProcedure);

            model.Id = tournament.Get<int>("@id");
        }

        private void SaveTournamentPrizes(IDbConnection connection, TournamentModel model)
        {
            foreach (PrizeModel prize in model.Prizes)
            {
                var p = new DynamicParameters();

                p.Add("@TournamentId", model.Id);
                p.Add("@PrizeId", prize.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournamentEntries(IDbConnection connection, TournamentModel model)
        {
            foreach (TeamModel team in model.teamModels)
            {
                var tm = new DynamicParameters();

                tm.Add("@TournamentId", model.Id);
                tm.Add("@TeamId", team.Id);
                tm.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentEntries_Insert", tm, commandType: CommandType.StoredProcedure);
            }
        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }

            return output;
        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                foreach (TeamModel team in output)
                {
                    var id = new DynamicParameters();
                    id.Add("@TeamId", team.Id);

                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", id, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }

        public List<TournamentModel> GetTournament_All()
        {
            List<TournamentModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<TournamentModel>("dbo.spTournaments_GetAll").ToList();
                var p = new DynamicParameters();

                foreach (TournamentModel tournament in output)
                {
                    p = new DynamicParameters();
                    p.Add("@TournamentId", tournament.Id);
                    tournament.Prizes = connection.Query<PrizeModel>("dbo.spPrizes_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    p = new DynamicParameters();
                    p.Add("@TournamentId", tournament.Id);
                    tournament.teamModels = connection.Query<TeamModel>("dbo.spTeam_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (TeamModel team in tournament.teamModels)
                    {
                        p = new DynamicParameters();
                        p.Add("@TeamId", team.Id);

                        team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                    }
                    p = new DynamicParameters();
                    p.Add("@TournamentId", tournament.Id);

                    List<MatchupModel> matchups = connection.Query<MatchupModel>("dbo.spMatchups_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (MatchupModel matchup in matchups)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupId", matchup.Id);

                        matchup.Entries = connection.Query<MatchupEntryModel>("dbo.spMatchupEntries_GetByMatchup", p, commandType: CommandType.StoredProcedure).ToList();

                        List<TeamModel> allTeams = GetTeam_All();

                        if (matchup.WinnerID > 0)
                        {
                            matchup.Winner = allTeams.Where(x => x.Id == matchup.WinnerID).First();
                        }

                        foreach (var me in matchup.Entries)
                        {
                            if (me.TeamCompetingId > 0)
                            {
                                me.TeamCompeting = allTeams.Where(x => x.Id == me.TeamCompetingId).First();
                            }

                            if (me.ParentMatchupId > 0)
                            {
                                me.ParentMatchup = matchups.Where(x => x.Id == me.ParentMatchupId).FirstOrDefault();
                            }
                        }
                    }
                    List<MatchupModel> currentRow = new List<MatchupModel>();
                    int currentRound = 1;

                    foreach (MatchupModel matchup in matchups)
                    {
                        if (matchup.MatchupRound > currentRound)
                        {
                            tournament.Rounds.Add(currentRow);
                            currentRow = new List<MatchupModel>();
                            currentRound += 1;
                        }

                        currentRow.Add(matchup);
                    }
                    tournament.Rounds.Add(currentRow);
                }
            }

            return output;
        }

        public void UpdateMatchup(MatchupModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var p = new DynamicParameters();
                if (model.Winner != null)
                {
                    p.Add("@Id", model.Id);
                    p.Add("@WinnerId", model.Winner.Id);

                    connection.Execute("dbo.spMatchups_Update", p, commandType: CommandType.StoredProcedure);
                }

                foreach (MatchupEntryModel me in model.Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        p = new DynamicParameters();
                        p.Add("@Id", me.Id);
                        p.Add("@TeamCompetingId", me.TeamCompeting.Id);
                        p.Add("@Score", me.Score);

                        connection.Execute("dbo.spMatchupEntries_Update", p, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }

        public void CompleteTournament(TournamentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Id", model.Id);

                connection.Execute("dbo.spTournaments_Complete", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
