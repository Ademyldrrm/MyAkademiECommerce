using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAkademiECommerce.Order.Application.Features.CQRS.Handlers;
using MyAkademiECommerce.Order.Application.Features.Mediator.Commands;
using MyAkademiECommerce.Order.Application.Features.Mediator.Queries;

namespace MyAkademiECommerce.Order.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderingController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> OrderingList()
        {
            var values = await _mediator.Send(new GetOrderingQuery());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrdering(CreateOrderingCommand createOrderingCommand)
        {
            await _mediator.Send(createOrderingCommand);
            return Ok("Sipariş Verildi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateOrdring(UpdateOrderingCommand updateOrderingCommand)
        {
            await _mediator.Send(updateOrderingCommand);
            return Ok("Sipraiş Güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrdering(int id)
        {
            var values=await _mediator.Send(new GetOrderingByIdQuery(id));
            return Ok(values);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteOrdering(int id)
        {
            await _mediator.Send(new RemoveOrderingCommand(id));
            return Ok("Sipariş silindi");
        }
    }
}