using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vantage.Models;

namespace Vantage.Data
{
    public static class HouseManagementData
    {
        // Return any data that may be needed regarding the duty sheet
        public static List<DutyModel> GetDuties()
        {
            var duties = new List<DutyModel>();

            for (var i = 0; i < 10; i++)
            {
                duties.Add(new DutyModel()
                {
                    Id = i,
                    Title = "Duty Title " + i,
                    Description = "This is a description of how to do this duty. There should be a decent amount of text here so I'm going to go ahead and make this string pretty long",
                    Performance = GenerateDutyPerformance((DutyStatus)Enum.Parse(typeof(DutyStatus), (i/2 - 2) + ""))
                });
            }

            return duties;
        }

        private static DutyStatus[] GenerateDutyPerformance(DutyStatus status)
        {
            var output = new DutyStatus[7];

            for (var i = 0; i < 7; i++)
            {
                output[i] = status;
            }

            return output;
        }
    }
}