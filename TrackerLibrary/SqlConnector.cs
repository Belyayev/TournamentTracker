﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO - make CreatePrize method to actually save to the database
        /// <summary>
        /// saves a new prize to the database
        /// </summary>
        /// <param name="model">the prize information</param>
        /// <returns>the prize information. including unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}