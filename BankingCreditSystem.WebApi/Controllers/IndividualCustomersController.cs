using BankingCreditSystem.Application.Features.IndividualCustomers.Commands.Create;
using BankingCreditSystem.Application.Features.IndividualCustomers.Queries.GetById;
using BankingCreditSystem.Application.Features.IndividualCustomers.Queries.GetIndividualCustomerList;
using BankingCreditSystem.Application.Features.IndividualCustomers.DTOs.Requests;
using Microsoft.AspNetCore.Mvc;

namespace BankingCreditSystem.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IndividualCustomersController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] GetIndividualCustomerListRequest request)
    {
        var query = new GetIndividualCustomerListQuery(request);
        var result = await Mediator.Send(query);
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var query = new GetByIdIndividualCustomerQuery { Id = id };
        var result = await Mediator.Send(query);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateIndividualCustomerRequest request)
    {
        var command = new CreateIndividualCustomerCommand { Request = request };
        var result = await Mediator.Send(command);
        return Created($"api/individualcustomers/{result.Id}", result);
    }
} 