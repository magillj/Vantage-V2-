using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vantage.Models
{
    public class DutyModel
    {
        public int Id { get; set; }
        public int AssigneeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DutyStatus[] Performance { get; set; }
    }

    public enum DutyStatus
    {
        Complete=1,
        MinorFail=-1,
        MajorFail=-2,
        Passed=2,
        Incomplete=0
    }
}