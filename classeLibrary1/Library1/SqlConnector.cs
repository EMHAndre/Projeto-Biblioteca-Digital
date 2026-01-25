using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method actually save to a database
        /// <summary>
        /// saves a new prize to the database
        /// </summary>
        /// <param name="model">the prize information.</param>
        /// <returns>prize information</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }

        //private string GetConnectionString()
        //{
        //    return ConfigurationManager.ConnectionStrings[db].ConnectionString;
        //}
    }
}
