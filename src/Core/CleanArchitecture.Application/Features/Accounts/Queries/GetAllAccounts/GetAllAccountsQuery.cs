using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.Wrappers;
using MediatR;

namespace CleanArchitecture.Application.Features.Accounts.Queries.GetAllAccounts
{
    public class GetAllAccountsQuery : IRequest<PagedResponse<IEnumerable<GetAllAccountsViewModel>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
