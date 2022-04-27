using System;
using System.Threading.Tasks;
using CleanArchitecture.Application.Features.Customers.Queries.GetAllCustomers;
using CleanArchitecture.Application.Features.Customers.Queries.GetCustomerById;
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
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Authorize(Roles = "customer-view")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllCustomers([FromQuery] RequestParameter filter)
        {
            return Ok(await _mediator.Send(new GetAllCustomersQuery() { PageSize = filter.PageSize, PageNumber = filter.PageNumber }));
        }
        
        [HttpGet("{id}")]
        [Authorize(Roles = "customer-view")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCustomerById(Guid id)
        {
            return Ok(await _mediator.Send(new GetCustomerByIdQuery { Id = id }));
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "customer-view")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCustomerAccounts(Guid id)
        {
            return Ok(await _mediator.Send(new GetCustomerByIdQuery { Id = id }));
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "customer-view")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCustomerTransactionsBetweenTimePeriod(Guid id)
        {
            return Ok(await _mediator.Send(new GetCustomerByIdQuery { Id = id }));
        }
    }
}
