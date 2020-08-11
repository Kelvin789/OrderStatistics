using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderStatistics.Models
{
    public partial class Orders
    {
        public int ID { get; set; }
        public int WeekID { get; set; }
        public Nullable<int> OrdersPlaced { get; set; }
        public Nullable<int> OrdersAuthorised { get; set; }
        public Nullable<decimal> TotalSales { get; set; }
    }
}
