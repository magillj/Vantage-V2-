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

        public static List<DutyModel> GetDuties()
        {
            var duties = new List<DutyModel>();

            for (var i = 0; i < 25; i++)
            {
                DutyStatus dutyStatus;
                if (i == 0)
                {
                    dutyStatus = DutyStatus.MajorFail;
                }
                else if (i == 1)
                {
                    dutyStatus = DutyStatus.MinorFail;
                }
                else if (i == 1)
                {
                    dutyStatus = DutyStatus.Incomplete;
                }
                else if (i == 1)
                {
                    dutyStatus = DutyStatus.Complete;
                }
                else 
                {
                    dutyStatus = DutyStatus.Passed;
                }

                duties.Add(new DutyModel()
                {
                    Id = i,
                    Title = "Duty Title " + i,
                    Description = "This is a description of how to do this duty. There should be a decent amount of text here so I'm going to go ahead and make this string pretty long",
                    Performance = GenerateDutyPerformance(dutyStatus)
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