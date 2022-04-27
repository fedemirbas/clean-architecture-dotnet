using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.Wrappers;
using MediatR;

namespace CleanArchitecture.Application.Features.Customers.Queries.GetCustomerById
{
    public class GetCustomerByIdQuery : IRequest<Response<GetCustomerByIdViewModel>>
    {
        public Guid Id { get; set; }
    }
}
