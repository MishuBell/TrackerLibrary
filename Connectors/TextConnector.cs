using System.Collections.Generic;
using TrackerLibrary.Connectors.TextConnectorHelpers;

namespace TrackerLibrary
{
    /// <summary>
    /// This represents the text connector to the database. It implements the IDataConnector interface.
    /// </summary>
    internal class TextConnector : IDataConnector
    {
        private const string PrizesFile = "PrizeModels.csv";

        // TODO - Make the CreatePrize method actually save to the text file.

        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            return model;
        }
    }
}
