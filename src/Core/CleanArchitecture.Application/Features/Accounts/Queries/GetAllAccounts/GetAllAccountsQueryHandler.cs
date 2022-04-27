using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchitecture.Application.Interfaces.Repositories;
using CleanArchitecture.Application.Wrappers;
using MediatR;

namespace CleanArchitecture.Application.Features.Accounts.Queries.GetAllAccounts
{
    public class GetAllAccountsQueryHandler : IRequestHandler<GetAllAccountsQuery, PagedResponse<IEnumerable<GetAllAccountsViewModel>>>
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;
        public GetAllAccountsQueryHandler(IAccountRepository accountRepository, IMapper mapper)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
        }

        public Task<PagedResponse<IEnumerable<GetAllAccountsViewModel>>> Handle(GetAllAccountsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
