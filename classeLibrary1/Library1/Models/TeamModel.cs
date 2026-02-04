using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1.Models
{
    public class TeamModel : DataAccess.IModeloComId
    {
        public int Id { get; set; }
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; }

        
    }
}
