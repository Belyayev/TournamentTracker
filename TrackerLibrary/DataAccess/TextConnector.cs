using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Collections.Generic;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        //TODO - wire up CreatePrize for text files
        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            //Load the text file
            //Convert the text file to List<PrizeModel>
            //Find the max ID
            //Add the new record with the new ID (max +1)
            //Convert the prizes to List<string>
            //Save the List<string> to the text file

            return model;
        }
    }
}
