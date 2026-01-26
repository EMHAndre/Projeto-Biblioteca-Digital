using Library1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1.DataAccess
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
        List<PersonModel> GetPerson_All();
        PersonModel CreatePerson(PersonModel model);
        void CreateTeam(TeamModel t);
        List<TeamModel> GetTeam_All();
        void CreateTournament(TournamentModel t);
    }

}
