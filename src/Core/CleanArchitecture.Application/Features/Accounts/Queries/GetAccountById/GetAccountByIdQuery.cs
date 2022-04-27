using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.Features.Accounts.Queries.GetAllAccounts;
using CleanArchitecture.Application.Wrappers;
using MediatR;

namespace CleanArchitecture.Application.Features.Accounts.Queries.GetAccountById
{
    public class GetAccountByIdQuery : IRequest<Response<GetAccountByIdViewModel>>
    {
        public Guid Id { get; set; }
    }
}
