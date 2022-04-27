using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.Wrappers;
using MediatR;

namespace CleanArchitecture.Application.Features.Accounts.Commands.AddingAccount
{
    public class AddingAccountCommand : IRequest<Response<Guid>>
    {
    }
}
