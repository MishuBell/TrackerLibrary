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
        public int Id { get; set; }

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

        public PrizeModel()
        {

        }

        /// <summary>
        /// Initializes a new instance of the PrizeModel class. Converts the string values to the appropriate data types.
        /// </summary>
        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            PlaceNumber = default;
            if (int.TryParse(placeNumber, out int placeNumberValue))
                PlaceNumber = placeNumberValue;

            PlaceName = "";
            PlaceName = placeName;

            PrizeAmount = default;
            if (decimal.TryParse(prizeAmount, out decimal prizeAmountValue))
                PrizeAmount = prizeAmountValue;

            PrizePercentage = default;
            if (double.TryParse(prizePercentage, out double prizePercentageValue))
                PrizePercentage = prizePercentageValue;
        }
    }
}
/*

Note that the parameterized constructor not only checks if the string values can be converted to the appropriate data types and assigns them when the conversion was succesfull. A safety measure has been implemented, by initializing the properties with default values, in case the conversion fails. This way, the properties will never be null.

The if statements are not necessary, but they are a good practice for me, because they make the code more readable and easier to understand.


*/