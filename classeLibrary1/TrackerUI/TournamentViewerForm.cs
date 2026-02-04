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
        

        public TournamentViewerForm(TournamentModel t)
        {
            InitializeComponent();
            tournament = t;
            LoadFormData();
        }

        private void teamTwoScoreText_TextChanged(object sender, EventArgs e)
        {

        }

            private void LoadFormData()
         {
             TournamentName.Text = tournament.TournamentName;

            rounds = tournament.Rounds
            .Select(r => r.First().MatchupRound)
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
          .Where(r => r.First().MatchupRound == round)
          .SelectMany(r => r)
          .ToList();

            matchupListBox.DataSource = null;
             matchupListBox.DataSource = selectedMatchups;
             matchupListBox.DisplayMember = "DisplayName";
         }

        private void LoadRounds()
        {
            rounds = new List<int>();

            for (int i = 0; i < tournament.Rounds.Count; i++)
            {
                rounds.Add(i + 1);
            }

            roundDropDown.DataSource = rounds;
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

        private void DisplayMatchupInfo(MatchupModel m)
        {
            if (m == null) return;

            teamOneName.Text = m.Entries[0].TeamCompeting?.TeamName ?? "TBD";
            teamTwoName.Text = m.Entries.Count > 1
                ? m.Entries[1].TeamCompeting?.TeamName ?? "TBD"
                : "BYE";

            teamOneScoreValue.Text = m.Entries[0].Score.ToString();
            teamTwoScoreValue.Text = m.Entries.Count > 1
                ? m.Entries[1].Score.ToString()
                : "";
        }

        private void DetermineWinner(MatchupModel m)
        {
            if (m.Entries[0].Score > m.Entries[1].Score)
            {
                m.Winner = m.Entries[0].TeamCompeting;
            }
            else
            {
                m.Winner = m.Entries[1].TeamCompeting;
            }
        }




    }
}
