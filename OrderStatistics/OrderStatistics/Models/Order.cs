using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderStatistics.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int WeekId { get; set; }
        public Nullable<int> OrdersPlaced { get; set; }
        public Nullable<int> OrdersAuthorised { get; set; }
        public Nullable<decimal> TotalSales { get; set; }
    }
}
