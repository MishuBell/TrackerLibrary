namespace TrackerLibrary
{
    /// <summary>
    /// Represents a Prize model for the tournament.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public  int  Id { get; set; }

        /// <summary>
        /// Gets or sets the place number of the prize.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Gets or sets the name of the place that the prize is awarded for.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Gets or sets the amount of the prize in dollars.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Gets or sets the percentage of the overall prize pool for this prize.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
