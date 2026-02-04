using Library1;
using Library1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class TournamentDashboardForm : Form
    {
        public TournamentDashboardForm()
        {
            InitializeComponent();
        }

        private List<TournamentModel> tournaments = new List<TournamentModel>();

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            tournaments = GlobalConfig.Connections[0].GetTournament_All();

            loadExistingTournamentDropDown.DataSource = tournaments;
            loadExistingTournamentDropDown.DisplayMember = "TournamentName";

        }


        private void loadExistingTournamentDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadTournamentBotton_Click(object sender, EventArgs e)
        {
            TournamentModel t = (TournamentModel)loadExistingTournamentDropDown.SelectedItem;

            if (t != null)
            {
                TournamentViewerForm frm = new TournamentViewerForm(t);
                frm.Show();
            }

        }

        private void createTournamentBotton_Click(object sender, EventArgs e)
        {

        }
    }
}
