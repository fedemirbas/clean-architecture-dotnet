using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.Features.Accounts.Queries.GetAccountDetailById;
using CleanArchitecture.Application.Wrappers;
using MediatR;

namespace CleanArchitecture.Application.Features.Accounts.Queries.GetAccountTransactionsById
{
    public class GetAccountTransactionsByIdQuery : IRequest<Response<GetAccountTransactionsByIdViewModel>>
    {
        public Guid Id { get; set; }
    }
}
