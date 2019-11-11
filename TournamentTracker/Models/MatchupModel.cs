using System.Collections.Generic;

namespace TournamentTracker
{
    public class MatchupModel
    {
        public int Id { get; set; }
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        public int WinnerID { get; set; }
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
        public string DisplayName
        {
            get
            {
                string output = "";

                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {me.TeamCompeting.TeamName}";
                        }  
                    }
                    else
                    {
                        output = "A párosítás még nincs meghatározva";
                        break;
                    }
                }

                return output;
            }
        }
    }
}
