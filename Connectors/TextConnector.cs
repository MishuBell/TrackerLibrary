namespace TrackerLibrary
{
    /// <summary>
    /// This represents the text connector to the database. It implements the IDataConnector interface.
    /// </summary>
    internal class TextConnector : IDataConnector
    {
        // TODO - Make the CreatePrize method actually save to the text file.
        /// <summary>
        /// Saves a new prize to the text file.
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
