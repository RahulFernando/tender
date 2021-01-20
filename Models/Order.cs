using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ceb_tender_app.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public DateTime Init { get; set; }
        public DateTime Opening { get; set; }
        public int Total { get; set; }
        public int ItemId { get; set; }
        public Boolean Document { get; set; } = false;
        public Item Item { get; set; }

        public Order()
        {
        }

        public Order(DateTime init, DateTime opening)
        {
            Init = init;
            Opening = opening;
        }
    }
}
