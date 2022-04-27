using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.Wrappers;
using MediatR;

namespace CleanArchitecture.Application.Features.Accounts.Queries.GetAccountDetailById
{
    public class GetAccountDetailByIdQuery : IRequest<Response<GetAccountDetailByIdViewModel>>
    {
        public Guid Id { get; set; }
    }
}
