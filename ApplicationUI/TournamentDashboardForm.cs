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
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> tournament = GlobalConfig.Connection.GetTournament_All();

        public TournamentDashboardForm()
        {
            InitializeComponent();

            WiredUpLists();
        }

        private void WiredUpLists()
        {
            selectExistingTournamentComboFix.DataSource = tournament;
            selectExistingTournamentComboFix.DisplayMember = "TournamentName";
        }

        private void loadTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentModel tm = (TournamentModel)selectExistingTournamentComboFix.SelectedItem;
            TournamentViewerForm form = new TournamentViewerForm(tm);
            form.Show();
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm form = new CreateTournamentForm();
            form.Show();
        }
    }
}
