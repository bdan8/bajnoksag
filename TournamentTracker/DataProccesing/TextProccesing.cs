using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace TournamentTracker.Text
{
    public static class TextProccesing
    {
        public static string FullFilePath(this string fileName)
        {
            //C:\Users\bagietMajster\source\repos\TournamentTracker\PrizeModel.csv
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static void SaveToPrizeModelFile(this List<PrizeModel> models)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines);
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');//adapting data from file

                PrizeModel prize = new PrizeModel();
                prize.Id = int.Parse(cols[0]);
                prize.PlaceNumber = int.Parse(cols[1]);
                prize.PlaceName = cols[2];
                prize.PrizeAmount = decimal.Parse(cols[3]);
                prize.PrizePercentage = double.Parse(cols[4]);

                output.Add(prize);
            }

            return output;
        }

        public static void SaveToPeopleFile(this List<PersonModel> models)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel person in models)
            {
                lines.Add($"{person.Id},{person.FirstName},{person.LastName},{person.EmailAddress},{person.CellPhoneNumber}");
            }

            File.WriteAllLines(GlobalConfig.PeopleFile.FullFilePath(), lines);
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel person = new PersonModel();

                person.Id = int.Parse(cols[0]);
                person.FirstName = cols[1];
                person.LastName = cols[2];
                person.EmailAddress = cols[3];
                person.CellPhoneNumber = cols[4];
                output.Add(person);
            }

            return output;
        }

        public static void SaveToTeamFile(this List<TeamModel> models)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel model in models)
            {
                lines.Add($"{model.Id},{model.TeamName},{ConvertPeopleListToString(model.TeamMembers)}");
            }

            File.WriteAllLines(GlobalConfig.TeamFile.FullFilePath(), lines);
        }

        public static void SaveRoundsToFile(this TournamentModel model)
        {
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    matchup.SaveMatchupToFile();
                }
            }
        }

        private static MatchupModel LookupMatchupById(int id)
        {
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();

            foreach (string matchup in matchups)
            {
                string[] cols = matchup.Split(',');
                if (cols[0] == id.ToString())
                {
                    List<string> matchingMatchups = new List<string>();
                    matchingMatchups.Add(matchup);
                    return matchingMatchups.ConvertToMatchupModels().First();
                }
            }
            return null;
        }

        public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
        {
            // id=0,TeamCompeting=1,Score=2,ParentMatchup=3
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                MatchupEntryModel matchupEntry = new MatchupEntryModel();

                matchupEntry.Id = int.Parse(cols[0]);
                if (cols[1].Length == 0)
                {
                    matchupEntry.TeamCompeting = null;
                }
                else
                {
                    matchupEntry.TeamCompeting = LookupTeamById(int.Parse(cols[1]));
                }
                matchupEntry.Score = double.Parse(cols[2]);

                int parentId = 0;
                if (int.TryParse(cols[3], out parentId))
                {
                    matchupEntry.ParentMatchup = LookupMatchupById(parentId);
                }
                else
                {
                    matchupEntry.ParentMatchup = null;
                }

                output.Add(matchupEntry);
            }
            return output;
        }

        private static List<MatchupEntryModel> ConvertStringToMatchupEntryModel(string input)
        {
            string[] ids = input.Split('|');
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            List<string> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();
            List<string> matchingEntries = new List<string>();

            foreach (string id in ids)
            {
                foreach (string entry in entries)
                {
                    string[] cols = entry.Split(',');

                    if (cols[0] == id)
                    {
                        matchingEntries.Add(entry);
                    }
                }
            }
            output = matchingEntries.ConvertToMatchupEntryModels();

            return output;
        }

        private static TeamModel LookupTeamById(int id)
        {
            List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();

            foreach (string team in teams)
            {
                string[] cols = team.Split(',');
                if (cols[0] == id.ToString())
                {
                    List<string> matchingTeams = new List<string>();
                    matchingTeams.Add(team);
                    return matchingTeams.ConvertToTeamModels().First();
                }
            }
            return null;
        }
        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            List<MatchupModel> output = new List<MatchupModel>();

            foreach (string line in lines)
            {
                //id-0,entires=1,winner=2,matchupround=3
                string[] cols = line.Split(',');//adapting data from file

                MatchupModel matchup = new MatchupModel();
                matchup.Id = int.Parse(cols[0]);
                matchup.Entries = ConvertStringToMatchupEntryModel(cols[1]);
                if (cols[2].Length == 0)
                {
                    matchup.Winner = null;
                }
                else
                {
                    matchup.Winner = LookupTeamById(int.Parse(cols[2]));
                }

                matchup.MatchupRound = int.Parse(cols[3]);

                output.Add(matchup);
            }

            return output;
        }

        public static void SaveMatchupToFile(this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            int currentId = 1;

            if (matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }

            matchup.Id = currentId;

            matchups.Add(matchup);

            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.SaveEntryToFile();
            }

            List<string> lines = new List<string>();

            foreach (MatchupModel model in matchups)
            {
                string winner = "";
                if (model.Winner != null)
                {
                    winner = model.Winner.Id.ToString();
                }
                lines.Add($"{model.Id},{ConvertMatchupEntryListToString(model.Entries)},{winner},{model.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }

        public static void UpdateMatchupToFile(this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            MatchupModel oldMatchup = new MatchupModel();

            foreach (MatchupModel m in matchups)
            {
                if (m.Id == matchup.Id)
                {
                    oldMatchup = m;
                }
            }
            matchups.Remove(oldMatchup);

            matchups.Add(matchup);

            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.UpdateEntryToFile();
            }

            List<string> lines = new List<string>();

            foreach (MatchupModel model in matchups)
            {
                string winner = "";
                if (model.Winner != null)
                {
                    winner = model.Winner.Id.ToString();
                }
                lines.Add($"{model.Id},{ConvertMatchupEntryListToString(model.Entries)},{winner},{model.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }

        public static void UpdateEntryToFile(this MatchupEntryModel entry)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();
            MatchupEntryModel oldEntry = new MatchupEntryModel();

            foreach (MatchupEntryModel e in entries)
            {
                if (e.Id == entry.Id)
                {
                    oldEntry = e;
                }
            }

            entries.Remove(oldEntry);

            entries.Add(entry);

            List<string> lines = new List<string>();

            foreach (MatchupEntryModel e in entries)
            {
                string parent = "";
                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                string teamCompeting = "";
                if (e.TeamCompeting != null)
                {
                    teamCompeting = e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{e.Id},{teamCompeting},{e.Score},{parent}");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }

        public static void SaveEntryToFile(this MatchupEntryModel entry)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            int currentId = 1;

            if (entries.Count > 0)
            {
                currentId = entries.OrderByDescending(x => x.Id).First().Id + 1;
            }

            entry.Id = currentId;
            entries.Add(entry);

            List<string> lines = new List<string>();

            foreach (MatchupEntryModel e in entries)
            {
                string parent = "";
                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                string teamCompeting = "";
                if (e.TeamCompeting != null)
                {
                    teamCompeting = e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{e.Id},{teamCompeting},{e.Score},{parent}");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }

        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";

            if (people.Count != 0)
            {
                foreach (PersonModel person in people)
                {
                    output += $"{person.Id}|";
                }

                output = output.Substring(0, output.Length - 1);//cuting last pipe sign
            }

            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel model = new TeamModel();
                model.Id = int.Parse(cols[0]);
                model.TeamName = cols[1];

                string[] personId = cols[2].Split('|');

                foreach (string id in personId)
                {
                    model.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }

                output.Add(model);
            }

            return output;
        }

        public static List<TournamentModel> ConvertToTournamentModels(
            this List<string> lines
            )
        {
            List<TournamentModel> output = new List<TournamentModel>();

            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0].Trim());
                tm.TournamentName = cols[1].Trim();
                tm.EntryFee = decimal.Parse(cols[2].Trim());

                string[] teamIds = cols[3].Split('|');

                foreach (string id in teamIds)
                {
                    tm.teamModels.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                if (cols[4].Length > 0)
                {
                    string[] prizeIds = cols[4].Split('|');

                    foreach (string id in prizeIds)
                    {
                        tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                    }
                }

                //Rounds information
                string[] rounds = cols[5].Split('|');

                foreach (string round in rounds)
                {
                    string[] msText = round.Split('^');
                    List<MatchupModel> ms = new List<MatchupModel>();

                    foreach (string matchupModelTextId in msText)
                    {
                        ms.Add(matchups.Where(x => x.Id == int.Parse(matchupModelTextId)).First());
                    }
                    tm.Rounds.Add(ms);
                }
                output.Add(tm);
            }
            return output;
        }

        public static void SaveToTournamentFile(this List<TournamentModel> models)
        {
            List<string> lines = new List<string>();

            foreach (TournamentModel tm in models)
            {
                lines.Add($"{tm.Id},{ tm.TournamentName},{ tm.EntryFee},{ConvertTeamListToString(tm.teamModels)},{ConvertPrizeListToString(tm.Prizes)},{ConvertRoundListToString(tm.Rounds)}");
            }
            File.WriteAllLines(GlobalConfig.TournamentFile.FullFilePath(), lines);
        }

        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";

            if (teams.Count != 0)
            {
                foreach (TeamModel team in teams)
                {
                    output += $"{team.Id}|";
                }

                output = output.Substring(0, output.Length - 1);//cuting last pipe sign
            }

            return output;
        }

        private static string ConvertMatchupEntryListToString(List<MatchupEntryModel> entries)
        {
            string output = "";

            if (entries.Count != 0)
            {
                foreach (MatchupEntryModel entry in entries)
                {
                    output += $"{entry.Id}|";
                }

                output = output.Substring(0, output.Length - 1);//cuting last pipe sign
            }

            return output;
        }

        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";

            if (prizes.Count != 0)
            {
                foreach (PrizeModel prize in prizes)
                {
                    output += $"{prize.Id}|";
                }

                output = output.Substring(0, output.Length - 1);//cuting last pipe sign
            }

            return output;
        }

        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";

            if (rounds.Count != 0)
            {
                foreach (List<MatchupModel> round in rounds)
                {
                    output += $"{ConvertMatchupListToString(round)}|";
                }

                output = output.Substring(0, output.Length - 1);//cuting last pipe sign
            }

            return output;
        }
        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";

            if (matchups.Count != 0)
            {
                foreach (MatchupModel round in matchups)
                {
                    output += $"{round.Id}^";
                }

                output = output.Substring(0, output.Length - 1);//cuting last pipe sign
            }

            return output;
        }
    }
}
