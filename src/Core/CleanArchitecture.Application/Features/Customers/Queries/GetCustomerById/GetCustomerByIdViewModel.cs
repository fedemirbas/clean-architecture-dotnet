using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Features.Customers.Queries.GetCustomerById
{
    public class GetCustomerByIdViewModel
    {
        public Guid Id { get; set; }
        public string CustomerFullName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }

    }
}
