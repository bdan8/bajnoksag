using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentTracker;

namespace ApplicationUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            tournament.OnTournamentComplete += Tournament_OnTournamentComplete;

            WireUpLists();

            LoadFormData();

            LoadRounds();
        }

        private void Tournament_OnTournamentComplete(object sender, bool e)
        {
            this.Close();
        }

        private void LoadFormData()
        {
            tournamentNameLabel.Text = tournament.TournamentName;
        }

        private void WireUpLists()
        {
            roundsComboBox.DataSource = rounds;
            matchUpListBox.DataSource = selectedMatchups;
            matchUpListBox.DisplayMember = "DisplayName";
        }

        private void LoadRounds()
        {
            rounds.Clear();

            rounds.Add(1);
            int currentRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if(matchups.First().MatchupRound>currentRound)
                {
                    currentRound = matchups.First().MatchupRound;
                    rounds.Add(currentRound);
                }
            }

            LoadMatchups(1);
        }

        private void roundsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundsComboBox.SelectedItem);
        }

        private void LoadMatchups(int round)
        {
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    foreach (MatchupModel m in matchups)
                    {
                        if (m.Winner == null || !unplayedOnlyCheckBox.Checked)
                        {
                            selectedMatchups.Add(m); 
                        }
                    }
                }
            }

            if (selectedMatchups.Count > 0) 
            {
                LoadMatchup(selectedMatchups.First()); 
            }

            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);

            firstScoreLabel.Visible = isVisible;
            firstTeamNameLabel.Visible = isVisible;
            firstTeamScoreLabel.Visible = isVisible;

            vsLabel.Visible = isVisible;

            secondScoreLabel.Visible = isVisible;
            secondTeamNameLabel.Visible = isVisible;
            secondTeamScoreLabel.Visible = isVisible;

            scoreButton.Visible = isVisible;
        }

        private void LoadMatchup(MatchupModel m)
        {
            if(m == null)
            {
                return;
            }
            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0) 
                {
                    if (m.Entries[0].TeamCompeting !=null)
                    {
                        firstTeamNameLabel.Text = m.Entries[0].TeamCompeting.TeamName;
                        firstTeamScoreLabel.Text = m.Entries[0].Score.ToString();

                        secondTeamNameLabel.Text = "<szabad>";
                        secondTeamScoreLabel.Text = "0";
                    }
                    else
                    {
                        firstTeamNameLabel.Text = "Még nincs eldöntve";
                        firstTeamScoreLabel.Text = "";
                    }
                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        secondTeamNameLabel.Text = m.Entries[1].TeamCompeting.TeamName;
                        secondTeamScoreLabel.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        secondTeamNameLabel.Text = "Még nincs eldöntve";
                        secondTeamScoreLabel.Text = "";
                    }
                }
            }
        }

        private void matchUpListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup((MatchupModel)matchUpListBox.SelectedItem);
        }

        private void unplayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundsComboBox.SelectedItem);
        }

        private string ValidateData()
        {
            string output = "";

            double teamOneScore = 0;
            double teamTwoScore = 0;

            bool scoreOneValid = double.TryParse(firstTeamScoreLabel.Text, out teamOneScore);
            bool scoreTwoValid = double.TryParse(secondTeamScoreLabel.Text, out teamTwoScore);

            if(!scoreOneValid || !scoreTwoValid)
            {
                output = "A hazai csapat eredménye nem valós szám";
            }
            else if (!scoreOneValid)
            {
                output = "A vendég csapat eredménye nem valós szám";
            }
            else if (teamOneScore == 0 && teamTwoScore == 0)
            {
                output = "Kérjük adjon meg eredményt mindkét csapatnak";
            }
            else if (teamOneScore == teamTwoScore) 
            {
                output = "Döntetlen nem engedélyezett.";
            }

            return output;
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateData();
            if (errorMessage.Length > 0) 
            {
                MessageBox.Show($"Beviteli hiba:{ errorMessage }");
                return;
            }
            MatchupModel m = (MatchupModel)matchUpListBox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(firstTeamScoreLabel.Text, out teamOneScore);

                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore; 
                        }
                        else
                        {
                            MessageBox.Show("Kérjük adjon meg valós eredményt a hazai csapatnak");
                            return;
                        }
                    }
                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(secondTeamScoreLabel.Text, out teamTwoScore);

                        if (scoreValid)
                        {
                            m.Entries[1].Score = teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("Kérjük adjon meg valós eredményt a vendég csapatnak");
                            return;
                        }
                    }
                }
            }
            try
            {
                TournamentLogic.UpdateTournamentResults(tournament);
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Az alkalmazásban a következő hiba történt: {exc.Message}");
            }

            LoadMatchups((int)roundsComboBox.SelectedItem);
        }
    }
}
