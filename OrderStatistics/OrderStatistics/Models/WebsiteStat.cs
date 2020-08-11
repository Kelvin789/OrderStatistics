using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderStatistics.Models
{
    public partial class WebsiteStat
    {
        public int ID { get; set; }
        public int WeekID { get; set; }
        public Nullable<decimal> PageLoadTime { get; set; }
        public Nullable<int> UniqueLogins { get; set; }
    }
}