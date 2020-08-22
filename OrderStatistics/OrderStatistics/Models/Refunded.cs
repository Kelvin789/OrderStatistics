using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderStatistics.Models
{
    public class Refunded
    {
        public int Id { get; set; }
        public int WeekId { get; set; }
        public Nullable<int> TotalQuantity { get; set; }
        public Nullable<int> TotalDamagedUnit { get; set; }
        public Nullable<decimal> TotalCost { get; set; }
    }
}