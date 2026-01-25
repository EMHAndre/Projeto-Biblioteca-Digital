using Library1.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;
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
            throw new System.NotImplementedException();
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            throw new System.NotImplementedException();
        }

        public TournamentModel CreateTournament(TournamentModel model)
        {
            throw new System.NotImplementedException();
        }

        public List<PersonModel> GetPerson_All()
        {
            throw new System.NotImplementedException();
        }
    }
    
}
