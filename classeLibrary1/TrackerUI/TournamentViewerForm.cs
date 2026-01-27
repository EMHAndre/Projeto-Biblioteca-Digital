using Library1;
using Library1.DataAccess;
using Library1.Models;
using System.Reflection;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        TournamentModel tournament;
        List<int> rounds = new List<int>();
        List<MatchupModel> selectedMatchups = new List<MatchupModel>();
        private TournamentModel? model;

        public TournamentViewerForm()
        {
            InitializeComponent();
            tournament = model;
            LoadFormData();
        }

        private void teamTwoScoreText_TextChanged(object sender, EventArgs e)
        {

        }

            private void LoadFormData()
         {
             TournamentName.Text = tournament.TournamentName;

             rounds = tournament.Rounds
                 .Select(x => x.MatchupRound)
                 .Distinct()
                 .OrderBy(x => x)
                 .ToList();

             roundDropDown.DataSource = rounds;
         }
         private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
         {
             LoadMatchups();
         }
         private void LoadMatchups()
         {
             int round = (int)roundDropDown.SelectedItem;

             selectedMatchups = tournament.Rounds
                 .Where(x => x.MatchupRound == round)
                 .ToList();

             matchupListBox.DataSource = null;
             matchupListBox.DataSource = selectedMatchups;
             matchupListBox.DisplayMember = "DisplayName";
         }

         private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
         {
             MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;

             if (m != null)
             {
                 teamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                 teamTwoName.Text = m.Entries.Count > 1
                     ? m.Entries[1].TeamCompeting.TeamName
                     : "<bye>";
             }
         }

         private void scoreButton_Click(object sender, EventArgs e)
         {
             MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;

             double teamOneScore = double.Parse(teamOneScoreValue.Text);
             double teamTwoScore = double.Parse(teamTwoScoreValue.Text);

             m.Entries[0].Score = teamOneScore;
             m.Entries[1].Score = teamTwoScore;

             m.Winner = teamOneScore > teamTwoScore
                 ? m.Entries[0].TeamCompeting
                 : m.Entries[1].TeamCompeting;

             foreach (IDataConnection db in GlobalConfig.Connections)
             {
                 db.UpdateMatchup(m);
             }

             LoadMatchups();
         }


    }
}
