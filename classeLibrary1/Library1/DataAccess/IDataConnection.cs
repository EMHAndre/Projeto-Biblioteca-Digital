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

        PrizeModel CreatePrize(PrizeModel modelo);
        PersonModel CreatePerson(PersonModel modelo);
        TeamModel CreateTeam(TeamModel modelo);
        TournamentModel CreateTournament(TournamentModel modelo);

        List<PersonModel> GetPerson_All();
        List<TeamModel> GetTeam_All();
        List<TournamentModel> GetTournament_All();

        void UpdateMatchup(MatchupModel matchup);

    }

}
