using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersService.Models
{
    public class OrderDetail
    {
        //public int Id { get; set; }
        public List<Order> Orders { get; set; }
    }
}
