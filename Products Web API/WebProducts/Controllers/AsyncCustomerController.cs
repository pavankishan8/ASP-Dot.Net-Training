using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebProducts.Models;

namespace WebProducts.Controllers
{
    public class AsyncCustomerController : ApiController
    {
        [ResponseType(typeof(Customer))]
        public async Task<IHttpActionResult> GetCustomer(int id)
        {
            var context = new Entities();
            var customer = context.Customers.FirstOrDefault((c) => c.CstId == id);
            if (customer == null)
                return NotFound();
            return await Task.Run<IHttpActionResult>(() => Ok(customer));
        }

        [ResponseType(typeof(List<Customer>))]
        public async Task<IHttpActionResult> GetAllCustomer()
        {
            var context = new Entities();
            var customer = context.Customers.ToList();
            return await Task.Run<IHttpActionResult>(() => Ok(customer));
        }
    }
}
