using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CustomerService.Controllers
{
    /// <summary>
    /// Represents a controller for managing customer data.
    /// </summary>
    /// <remarks>
    /// This controller provides endpoints for retrieving and adding customer information.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Retrieve all customers
    /// GET /Customer
    /// 
    /// // Add a new customer
    /// POST /Customer
    /// {
    ///     "FirstName": "John",
    ///     "Surname": "Doe",
    ///     "ID": 123
    /// }
    /// </code>
    /// </example>
    /// <seealso cref="ControllerBase" />[ApiController]
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