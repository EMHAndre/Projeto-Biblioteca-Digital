using Dapper;
using Library1.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "Tournaments";
        // TODO - Make the CreatePrize method actually save to a database
        /// <summary>
        /// saves a new prize to the database
        /// </summary>
        /// <param name="model">the prize information.</param>
        /// <returns>prize information</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                SqlCommand cmd = new SqlCommand("dbo.spPrizes_Insert", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PlaceNumber", model.PlaceNumber);
                cmd.Parameters.AddWithValue("@PlaceName", model.PlaceName);
                cmd.Parameters.AddWithValue("@PrizeAmount", model.PrizeAmount);
                cmd.Parameters.AddWithValue("@PrizePercentage", model.PrizePercentage);

                SqlParameter p = new SqlParameter();
                p.ParameterName = "@Id";
                p.SqlDbType = SqlDbType.Int;
                p.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(p);

                connection.Open();
                cmd.ExecuteNonQuery();

                model.Id = (int)p.Value;
                return model;
            }
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                SqlCommand cmd = new SqlCommand("dbo.spPeople_Insert", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
                cmd.Parameters.AddWithValue("@LastName", model.LastName);
                cmd.Parameters.AddWithValue("@EmailAddress", model.EmailAddress);
                cmd.Parameters.AddWithValue("@CellphoneNumber", model.CellphoneNumber);

                connection.Open();
                cmd.ExecuteNonQuery();
            }

            return model;
        }

        public void CreateTeam(TeamModel model)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                connection.Open();

                // Insert Team
                SqlCommand cmd = new SqlCommand("dbo.spTeams_Insert", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TeamName", model.TeamName);

                SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int);
                idParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(idParam);

                cmd.ExecuteNonQuery();
                model.Id = (int)idParam.Value;

                // Insert Team Members
                foreach (PersonModel p in model.TeamMembers)
                {
                    SqlCommand memberCmd = new SqlCommand("dbo.spTeamMembers_Insert", connection);
                    memberCmd.CommandType = CommandType.StoredProcedure;

                    memberCmd.Parameters.AddWithValue("@TeamId", model.Id);
                    memberCmd.Parameters.AddWithValue("@PersonId", p.Id);

                    memberCmd.ExecuteNonQuery();
                }
            }
        }

        public void CreateTournament(TournamentModel model)
        {

            using (SqlConnection connection =
                new SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                connection.Open();

                // 1. Create Tournament
                SqlCommand cmd = new SqlCommand("dbo.spTournaments_Insert", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TournamentName", model.TournamentName);
                cmd.Parameters.AddWithValue("@EntryFee", model.EntryFee);

                SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int);
                idParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(idParam);

                cmd.ExecuteNonQuery();
                model.Id = (int)idParam.Value;

                // 2. Insert Teams
                foreach (TeamModel team in model.EnteredTeams)
                {
                    SqlCommand teamCmd =
                        new SqlCommand("dbo.spTournamentEntries_Insert", connection);
                    teamCmd.CommandType = CommandType.StoredProcedure;

                    teamCmd.Parameters.AddWithValue("@TournamentId", model.Id);
                    teamCmd.Parameters.AddWithValue("@TeamId", team.Id);

                    teamCmd.ExecuteNonQuery();
                }

                // 3. Insert Prizes
                foreach (PrizeModel prize in model.Prizes)
                {
                    SqlCommand prizeCmd =
                        new SqlCommand("dbo.spTournamentPrizes_Insert", connection);
                    prizeCmd.CommandType = CommandType.StoredProcedure;

                    prizeCmd.Parameters.AddWithValue("@TournamentId", model.Id);
                    prizeCmd.Parameters.AddWithValue("@PrizeId", prize.Id);

                    prizeCmd.ExecuteNonQuery();
                }
            }
        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output = new List<PersonModel>();

            using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                SqlCommand cmd = new SqlCommand("dbo.spPeople_GetAll", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PersonModel p = new PersonModel
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            EmailAddress = reader.GetString(3),
                            CellphoneNumber = reader.GetString(4)
                        };

                        output.Add(p);
                    }
                }
            }

            return output;
        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output = new List<TeamModel>();

            using (SqlConnection connection =
                new SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                SqlCommand cmd = new SqlCommand("dbo.spTeams_GetAll", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TeamModel team = new TeamModel
                        {
                            Id = reader.GetInt32(0),
                            TeamName = reader.GetString(1)
                        };

                        team.TeamMembers = GetTeamMembers(team.Id, connection);

                        output.Add(team);
                    }
                }
            }
              return output;
        }

        private List<PersonModel> GetTeamMembers(int teamId, SqlConnection connection)
        {
            List<PersonModel> output = new List<PersonModel>();

            SqlCommand cmd = new SqlCommand("dbo.spTeamMembers_GetByTeam", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TeamId", teamId);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    output.Add(new PersonModel
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        EmailAddress = reader.GetString(3),
                        CellphoneNumber = reader.GetString(4)
                    });
                }
            }

            return output;
        }


        public List<TournamentModel> GetTournament_All()
        {
            List<TournamentModel> output;

            using (SqlConnection connection =
                new SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                output = connection.Query<TournamentModel>(
                    "dbo.spTournaments_GetAll",
                    commandType: CommandType.StoredProcedure
                ).ToList();
            }

            return output;
        }
        public void UpdateMatchup(MatchupModel model)
        {
            using (SqlConnection connection =
                new SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                foreach (MatchupEntryModel entry in model.Entries)
                {
                    connection.Execute(
                        "dbo.spMatchupEntries_Update",
                        new { entry.Id, entry.Score },
                        commandType: CommandType.StoredProcedure
                    );
                }

                if (model.Winner != null)
                {
                    connection.Execute(
                        "dbo.spMatchups_Update",
                        new { model.Id, WinnerId = model.Winner.Id },
                        commandType: CommandType.StoredProcedure
                    );
                }
            }
        }


    }

}
