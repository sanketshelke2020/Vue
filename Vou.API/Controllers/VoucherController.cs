using System.Text.Json.Serialization;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Vou.Application.Features.Voucher.Commands.CreateVoucher;
using Vou.Application.Features.Voucher.Queries.GetVoucherList;
using Newtonsoft.Json;
using Serilog.Events;

namespace Vou.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly IMediator _mediator;
        private static readonly Serilog.ILogger _logger = Log.ForContext<VoucherController>();

        public VoucherController(IMediator mediator){
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetVouchers()
        {
            Console.WriteLine($"Is Error Enabled: {Log.IsEnabled(LogEventLevel.Error)}");

            Console.WriteLine($"Current log level: {Log.Logger.IsEnabled(LogEventLevel.Information)}");
            _logger.Error("This is a critical error message to test logging.");

            _logger.Information("GetVouchers called");
            var response = await _mediator.Send(new GetVoucherListQuery());
            _logger.Information("GetVouchers End");
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateVoucher(CreateVoucherCommand createVoucherCommand)
        {
            try{

            _logger.Information("CreateVoucher called RequestBody : {requestBody}", JsonConvert.SerializeObject(createVoucherCommand));
            throw new Exception("Voucher Controller Exception");
            var response = await _mediator.Send(createVoucherCommand);
            return Ok(response);
            }
            catch (Exception ex)
            {
                // _logger.Error(ex, "Error occurred while creating voucher: {errorMessage}", ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
            }
        }
    }
}
