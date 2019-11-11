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
    public partial class CreateTeamsForm : Form
    {
        private List<PersonModel> availableTeamMembers =GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        ITeamRequester callingForm;

        public CreateTeamsForm(ITeamRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            WiredUpLists();
        }

        private void WiredUpLists()
        {
            selectTeamMemberComboBox.DataSource = null;
            selectTeamMemberComboBox.DataSource = availableTeamMembers;
            selectTeamMemberComboBox.DisplayMember = nameof(PersonModel.FullName);

            teamMemeberListBox.DataSource = null;
            teamMemeberListBox.DataSource = selectedTeamMembers;
            teamMemeberListBox.DisplayMember = nameof(PersonModel.FullName);
        }

        private void createMemeberButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PersonModel person = new PersonModel();

                person.FirstName = firstNameValue.Text;
                person.LastName = lastNameValue.Text;
                person.EmailAddress = emailValue.Text;
                person.CellPhoneNumber = cellphoneValue.Text;

                GlobalConfig.Connection.CreatePerson(person);
                availableTeamMembers.Add(person);

                WiredUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("Kérjük töltse ki az összes mezőt.");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0) 
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (emailValue.Text.Length == 0) 
            {
                return false;
            }
            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void addTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel person = (PersonModel)selectTeamMemberComboBox.SelectedItem;

            if(person!=null)
            {
                availableTeamMembers.Remove(person);
                selectedTeamMembers.Add(person);

                WiredUpLists();
            }
        }

        private void deleteSelectedMember_Click(object sender, EventArgs e)
        {
            PersonModel person = (PersonModel)teamMemeberListBox.SelectedItem;

            if (person != null)
            {
                selectedTeamMembers.Remove(person);
                availableTeamMembers.Add(person);

                WiredUpLists();
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel model = new TeamModel();

            model.TeamName = teamNameValue.Text;
            model.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(model);
            callingForm.TeamComplete(model);
            this.Close();
        }
    }
}
