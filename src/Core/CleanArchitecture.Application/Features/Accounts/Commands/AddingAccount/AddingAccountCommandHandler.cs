using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchitecture.Application.Interfaces.Repositories;
using CleanArchitecture.Application.Wrappers;
using MediatR;

namespace CleanArchitecture.Application.Features.Accounts.Commands.AddingAccount
{
    public class AddingAccountCommandHandler : IRequestHandler<AddingAccountCommand, Response<Guid>>
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;
        public AddingAccountCommandHandler(IAccountRepository accountRepository, IMapper mapper)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
        }

        public Task<Response<Guid>> Handle(AddingAccountCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
