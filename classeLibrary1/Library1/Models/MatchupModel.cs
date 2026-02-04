using Library1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1.Models
{
    public  class MatchupModel : IModeloComId
    {
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
        public object Id { get; internal set; }

        int IModeloComId.Id { get => throw new NotImplementedException(); set => Id = value; }
    }
}
