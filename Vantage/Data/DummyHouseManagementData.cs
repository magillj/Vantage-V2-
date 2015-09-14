using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vantage.Data
{
    public static class DummyHouseManagementData
    {
        // Return any data that may be needed regarding the duty sheet
        public static List<string> GetTestList()
        {
            return new List<string>()
            {
                "Derek Sucks 1",
                "Derek Sucks 2",
                "Derek Sucks 3",
                "Derek Sucks 4",
                "Derek Sucks 5"
            };
        } 
    }
}