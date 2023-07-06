using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace TrackerLibrary
{
    /// <summary>
    /// This represents the SQL connector to the database. It implements the IDataConnector interface.
    /// </summary>
    public class SqlConnector : IDataConnector
    {
        // TODO - Make the CreatePrize method actually save to the database.
        /// <summary>
        /// Saves a new prize to the database.
        /// </summary>
        /// <param name="model">The PrizeModel instance containing the prize details.</param>
        /// <returns>The PrizeModel instance including a new unique ID.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var dP = new DynamicParameters();
                dP.Add("@PlaceNumber", model.PlaceNumber);
                dP.Add("@PlaceName", model.PlaceName);
                dP.Add("@PrizeAmount", model.PrizeAmount);
                dP.Add("@PrizePercentage", model.PrizePercentage);
                dP.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", dP, commandType: CommandType.StoredProcedure);

                model.Id = dP.Get<int>("@id");

                return model;
            }
        }
    }
}

/*

We want to return a PrizeModel ... but we also need to take a prize model as a parameter. 











*/
