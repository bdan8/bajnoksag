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
    public partial class CreateTournamentForm : Form ,IPrizeRequester ,ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();

            WiredUpLists();
        }

        private void WiredUpLists()
        {
            selectTeamComboBox.DataSource = null;
            selectTeamComboBox.DataSource = availableTeams;
            selectTeamComboBox.DisplayMember = nameof(TeamModel.TeamName);

            teamPlayerListBox.DataSource = null;
            teamPlayerListBox.DataSource = selectedTeams;
            teamPlayerListBox.DisplayMember = nameof(TeamModel.TeamName);

            prizeListBox.DataSource = null;
            prizeListBox.DataSource = selectedPrizes;
            prizeListBox.DisplayMember = nameof(PrizeModel.PlaceName);
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel team = (TeamModel)selectTeamComboBox.SelectedItem;

            if(team != null)
            {
                availableTeams.Remove(team);
                selectedTeams.Add(team);

                WiredUpLists();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //call the crearedPrizeForm
            CreatePrizeForm form = new CreatePrizeForm(this);
            form.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);

            WiredUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);

            WiredUpLists();
        }

        private void creatTeamLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamsForm form = new CreateTeamsForm(this);

            form.Show();
        }

        private void deleteSelectedPlayersButton_Click(object sender, EventArgs e)
        {
            TeamModel team = (TeamModel)teamPlayerListBox.SelectedItem;

            if(team != null)
            {
                selectedTeams.Remove(team);
                availableTeams.Add(team);

                WiredUpLists();
            }
        }

        private void deleteSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel prize = (PrizeModel)prizeListBox.SelectedItem;

            if(prize != null)
            {
                selectedPrizes.Remove(prize);

                WiredUpLists();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            decimal fee = 0;
            bool validateFee = decimal.TryParse(entryFeeValue.Text, out fee);
            if(!validateFee)
            {
                MessageBox.Show("Kérjük adjon meg nevezési díjat", "a nevezési díj nem lehet 0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tournamentNameValue.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.teamModels = selectedTeams;

            TournamentLogic.CreateRounds(tm);

            GlobalConfig.Connection.CreateTournament(tm);

            tm.AlertUsersToNewRound();

            TournamentViewerForm form = new TournamentViewerForm(tm);
            form.Show();
            this.Close();
        }
    }
}
