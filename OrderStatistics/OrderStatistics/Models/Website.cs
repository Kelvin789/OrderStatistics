using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderStatistics.Models
{
    public partial class Website
    {
        public int Id { get; set; }
        public int WeekId { get; set; }
        public Nullable<decimal> PageLoadTime { get; set; }
        public Nullable<int> UniqueLogins { get; set; }
    }
}