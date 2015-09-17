using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Vantage.Models
{
    public class DutySheetViewModel
    {
        public int WeekDay { get; set;  }
        public List<DutyModel> Duties { get; set; }
    }
}