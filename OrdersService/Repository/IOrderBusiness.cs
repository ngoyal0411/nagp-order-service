using OrdersService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersService.Repository
{
    public interface IOrderBusiness
    {
        OrderDetail GetAll();
        OrderDetail GetById(int id);
    }
}
