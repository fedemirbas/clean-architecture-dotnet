using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.Wrappers;
using MediatR;

namespace CleanArchitecture.Application.Features.Customers.Queries.GetAllCustomers
{
    public class GetAllCustomersQuery : IRequest<PagedResponse<IEnumerable<GetAllCustomersViewModel>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
