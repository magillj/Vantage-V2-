using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vantage.Models;

namespace Vantage.Data
{
    public static class HomeData
    {
        public static List<AnnouncementModel> GetAnnouncements()
        {
            var dummyOutput = new List<AnnouncementModel>();

            for (var i = 0; i < 8; i++)
            {
                dummyOutput.Add(new AnnouncementModel()
                {
                    Id = i,
                    IsCritical = i == 1, // set the second message as critical
                    Title = "Announcement " + i + " has been made by someone important!!",
                    Body = "There is an important announcement that everyone needs to see. Only certain people will have the priveldges necessary to create announcements so it doesn't get flooded with the usual \"High Priority\" stuff"
                });
            }

            return dummyOutput;
        }
    }
}