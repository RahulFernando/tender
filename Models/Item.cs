using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ceb_tender_app.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Order> Orders { get; set; }

        public Item()
        {
        }

        public Item(string code, string name, string description, List<Order> orders)
        {
            Code = code;
            Name = name;
            Description = description;
            Orders = orders;
        }
    }
}
