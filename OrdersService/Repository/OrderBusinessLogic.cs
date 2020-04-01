using OrdersService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersService.Repository
{
    public class OrderBusinessLogic : IOrderBusiness
    {
        private OrderDetail _orders =  new OrderDetail
        {
                //Id =1,
                Orders= new List<Order>
                {
                   new Order
                   {
                        Id=1,
                        Amount=250,
                        DateTime="29-March-2020"
                   },
                   new Order
                   {
                        Id=2,
                        Amount=1000,
                        DateTime="30-March-2020"
                   },
                   new Order
                   {
                        Id=3,
                        Amount=1500,
                        DateTime="31-March-2020"
                   }
                }
            
        };
        public OrderDetail GetAll()
        {
            return _orders;
        }

        //For now I am fetching the first record with id 1 always.
        public OrderDetail GetById(int id)
        {
            return _orders;
        }
    }
}
