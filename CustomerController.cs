using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CustomerService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private static readonly List<Customer> Customers = new List<Customer>();

        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return Customers;
        }

        [HttpPost]
        public void AddCustomer([FromBody] Customer newCustomer)
        {
            Customers.Add(newCustomer);
        }
    }
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private static readonly List<Customer> Customers = new List<Customer>();

        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return Customers;
        }

        [HttpPost]
        public void AddCustomer([FromBody] Customer newCustomer)
        {
            Customers.Add(newCustomer);
        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int ID { get; set; }
    }
}