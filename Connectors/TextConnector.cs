using System.Collections.Generic;
using System.Linq;
using TrackerLibrary.Connectors.TextConnectorHelpers;

namespace TrackerLibrary
{
    /// <summary>
    /// A data connector for text files.
    /// </summary>
    internal class TextConnector : IDataConnector
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConverToPersonModels();
        }

        /// <summary>
        /// Creates a PrizeModel instance and saves it to a text file.
        /// </summary>
        /// <param name="model">The PrizeModel to be created.</param>
        /// <returns>The created PrizeModel instance.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);
            return model;
        }
    }
}