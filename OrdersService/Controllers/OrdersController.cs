using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrdersService.Models;
using OrdersService.Repository;

namespace OrdersService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private IOrderBusiness _orderBusiness;
        public OrdersController(IOrderBusiness orderBusiness)
        {
            _orderBusiness = orderBusiness;
        }
        // GET: api/Orders
        [HttpGet]
        public OrderDetail Get()
        {
            return _orderBusiness.GetAll();
        }

        // GET: api/Orders/5
        [HttpGet("{id}", Name = "Get")]
        public OrderDetail Get(int id)
        {
            return _orderBusiness.GetById(id);
        }

        // POST: api/Orders
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Orders/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
