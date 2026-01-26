using Library1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Library1.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // TODO - Wire up the CreatePrize for text files.
        public PrizeModel CreatePrize(PrizeModel model)
        { 
            // TODO - salvar em ficheiro de texto
            return model;
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            model.Id = 1; // temporário
            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            model.Id = 1; // temporário
            return model;
        }

        public TournamentModel CreateTournament(TournamentModel model)
        {
            throw new System.NotImplementedException();
        }

        public List<PersonModel> GetPerson_All()
        {
            throw new System.NotImplementedException();
        }

        void IDataConnection.CreateTeam(TeamModel t)
        {
            return;
        }
    }
    
}