using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.Wrappers;
using MediatR;

namespace CleanArchitecture.Application.Features.Accounts.Commands.WithdrawingAccount
{
    public class WithdrawingAccountCommand : IRequest<Response<Guid>>
    {
    }
}
