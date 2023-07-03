namespace TrackerLibrary
{
    /// <summary>
    /// With this interface, a class can save data to a database.
    /// </summary>
    public interface IDataConnector
    {
        /// <summary>
        /// Saves the prize to the database.
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns> A prize model </returns>
        PrizeModel CreatePrize(PrizeModel model);
    }
}
