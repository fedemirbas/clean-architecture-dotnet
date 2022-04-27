using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchitecture.Application.Interfaces.Repositories;
using CleanArchitecture.Application.Wrappers;
using MediatR;

namespace CleanArchitecture.Application.Features.Accounts.Commands.WithdrawingAccount
{
    public class WithdrawingAccountCommandHandler : IRequestHandler<WithdrawingAccountCommand, Response<Guid>>
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;
        public WithdrawingAccountCommandHandler(IAccountRepository accountRepository, IMapper mapper)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
        }

        public Task<Response<Guid>> Handle(WithdrawingAccountCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
