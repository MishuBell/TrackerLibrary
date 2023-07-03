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
            model.Id = 1;
            return model;
        }
    }
}

/*

We want to return a PrizeModel ... but we also need to take a prize model as a parameter. 











*/
