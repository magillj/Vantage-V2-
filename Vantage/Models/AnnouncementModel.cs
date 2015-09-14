using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vantage.Models
{
    public class AnnouncementModel
    {
        public int Id { get; set; }
        public bool IsCritical { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}