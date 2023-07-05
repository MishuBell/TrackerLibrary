using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace TrackerLibrary.Connectors.TextConnectorHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            // Gets the file path from app settings
            string filePath = ConfigurationManager.AppSettings["filePath"];
            // Returns the full file path by combining the file path and file name
            return $"{filePath}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }

            return output;
        }
    }
}

/*
This is now an extension method. It is a static class with a static method. The method is called FullFilePath and it takes a string parameter called fileName. The method returns a string. The method is c

The reason this is in its own namespace is, because we dont want every string to be cluttered with this method. We only want to use this method when we are dealing with a file path. So, we put it in its own namespace.

*/