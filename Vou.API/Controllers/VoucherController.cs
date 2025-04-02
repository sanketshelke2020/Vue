using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vou.Application.Features.Voucher.Queries.GetVoucherList;

namespace Vou.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VoucherController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetVouchers()
        {
            var response = await _mediator.Send(new GetVoucherListQuery());
            return Ok(response);
        }
    }
}
