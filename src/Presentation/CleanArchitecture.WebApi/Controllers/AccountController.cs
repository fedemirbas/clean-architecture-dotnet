using System;
using System.Threading.Tasks;
using CleanArchitecture.Application.Features.Accounts.Commands.AddingAccount;
using CleanArchitecture.Application.Features.Accounts.Commands.WithdrawingAccount;
using CleanArchitecture.Application.Features.Accounts.Queries.GetAccountById;
using CleanArchitecture.Application.Features.Accounts.Queries.GetAccountDetailById;
using CleanArchitecture.Application.Features.Accounts.Queries.GetAccountTransactionsById;
using CleanArchitecture.Application.Features.Accounts.Queries.GetAllAccounts;
using CleanArchitecture.Application.Parameters;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    [Produces("application/json")]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Authorize(Roles = "account-view")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllAccounts([FromQuery] RequestParameter filter)
        {
            return Ok(await _mediator.Send(new GetAllAccountsQuery() { PageSize = filter.PageSize, PageNumber = filter.PageNumber }));
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "account-view")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAccountById(Guid id)
        {
            return Ok(await _mediator.Send(new GetAccountByIdQuery { Id = id }));
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "account-view")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAccountTransactionsById(Guid id)
        {
            return Ok(await _mediator.Send(new GetAccountTransactionsByIdQuery() { Id = id }));
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "account-view")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAccountDetailById(Guid id)
        {
            return Ok(await _mediator.Send(new GetAccountDetailByIdQuery() { Id = id }));
        }

        [HttpPost]
        [Authorize(Roles = "account-action")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> AddingAccount(AddingAccountCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPost]
        [Authorize(Roles = "account-action")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> WithdrawingAccount(WithdrawingAccountCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
