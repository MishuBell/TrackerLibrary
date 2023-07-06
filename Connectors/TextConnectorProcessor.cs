using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

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
                PrizeModel p = new PrizeModel
                {
                    Id = int.Parse(cols[0]),
                    PlaceNumber = int.Parse(cols[1]),
                    PlaceName = cols[2],
                    PrizeAmount = decimal.Parse(cols[3]),
                    PrizePercentage = double.Parse(cols[4])
                };
                output.Add(p);
            }

            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}

/*
This is now an extension method. It is a static class with a static method. The method is called FullFilePath and it takes a string parameter called fileName. The method returns a string. The method is c

The reason this is in its own namespace is, because we dont want every string to be cluttered with this method. We only want to use this method when we are dealing with a file path. So, we put it in its own namespace.

An extension method is a C# language feature that allows developers to add new methods to an existing type without modifying that type's source code. It is defined as a static method within a static class and requires a special syntax when calling it on the target instance.
In the provided code example, the FullFilePath extension method adds a new method to the string type. This enables the method to be called on any instance of a string without making any modifications to the existing string code.

*/