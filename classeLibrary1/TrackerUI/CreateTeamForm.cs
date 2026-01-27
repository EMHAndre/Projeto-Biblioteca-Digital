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
using Microsoft.Data.SqlClient;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = new List<PersonModel>();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm()
        {
            InitializeComponent();
            LoadTeamMembers();
            WireUpLists();
        }

        private void CreateTeamForm_Load(object sender, EventArgs e)
        {
            //availableTeamMembers = GlobalConfig.Connections[0].GetPerson_All();
        }
        private void LoadTeamMembers()
        {
            availableTeamMembers = GlobalConfig.Connections[0].GetPerson_All();
        }

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;
            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void createTeamBotton_Click(object sender, EventArgs e)
        {

            TeamModel t = new TeamModel
            {
                TeamName = teamNameValue.Text,
                TeamMembers = selectedTeamMembers
            };

            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                db.CreateTeam(t);
            }

            MessageBox.Show("Team created successfully!");


        }

        private void createMemberBotton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {

                PersonModel p = new PersonModel
                {
                    FirstName = firstNameValue.Text,
                    LastName = lastNameValue.Text,
                    EmailAddress = emailValue.Text,
                    CellphoneNumber = cellphoneValue.Text
                };

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePerson(p);
                }

                selectedTeamMembers.Add(p);
                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all the fields.");
            }

        }
        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0) return false;
            if (lastNameValue.Text.Length == 0) return false;
            if (emailValue.Text.Length == 0) return false;
            if (cellphoneValue.Text.Length == 0) return false;

            return true;
        }


        private void emailValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void teamMembersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TeamNameValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectTeamMemberDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void deleteMemberPlayersButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);
                WireUpLists();
            }
        }
    }
}
