using Library1;
using Library1.DataAccess;
using Library1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form
    {
        private List<TeamModel> availableTeams = new List<TeamModel>();
        private List<TeamModel> selectedTeams = new List<TeamModel>();
        private List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
        }

        private void CreateTournamentForm_Load(object sender, EventArgs e)
        {
            availableTeams = GlobalConfig.Connections[0].GetTeam_All();
            WireUpLists();
        }

        private void WireUpLists()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";

            selectTeamDropDown.DataSource = GlobalConfig.Connections[0].GetTeam_All();
            selectTeamDropDown.DisplayMember = "TeamName";
        }

        private void LoadTeamList()
        {
            availableTeams = GlobalConfig.Connections[0].GetTeam_All();
        }


        private void TournamentValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeamTwoScoreText_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteSelectedPlayersButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteSelecterdPrizeButton_Click(object sender, EventArgs e)
        {

        }

        private void TournamentPlayersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prizeslistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectTeamDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }

        }

        private void CreatePrizeBotton_Click(object sender, EventArgs e)
        {
            CreatePrizeForm frm = new CreatePrizeForm();
            frm.Show();
        }

        private void CreateTournamentBotton_Click(object sender, EventArgs e)
        {
              TournamentModel t = new TournamentModel
              {
                  TournamentName = tournamentNameValue.Text,
                  EntryFee = decimal.Parse(entryFeeValue.Text),
                  EnteredTeams = selectedTeams,
                  Prizes = selectedPrizes
              };

              foreach (IDataConnection db in GlobalConfig.Connections)
              {
                  db.CreateTournament(t);
              }

            MessageBox.Show("Tournament created successfully!");
        }
    }
}
