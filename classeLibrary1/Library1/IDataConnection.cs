using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
    }

}
