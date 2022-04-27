using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Features.Customers.Queries.GetAllCustomers
{
    public class GetAllCustomersViewModel
    {
        public Guid Id { get; set; }
        public string CustomerFullName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }
    }
}
