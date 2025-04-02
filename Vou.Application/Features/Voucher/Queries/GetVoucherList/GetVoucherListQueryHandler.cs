using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Vou.Application.Features.Voucher.Queries.GetVoucherList
{
    public class GetVoucherListQueryHandler : IRequestHandler<GetVoucherListQuery,List<GetVoucherListDto>>
    {
        Task<List<GetVoucherListDto>> IRequestHandler<GetVoucherListQuery, List<GetVoucherListDto>>.Handle(GetVoucherListQuery request, CancellationToken cancellationToken)
        {
            var vouchers = new List<GetVoucherListDto>
    {
        new GetVoucherListDto
        {
            VoucherNumber = 1,
            Name = "Flipkart",
            Description = "Flipkart 100 Rupees Voucher"
        },
        new GetVoucherListDto
        {
            VoucherNumber = 2,
            Name = "Amazon",
            Description = "Amazon 100 Rupees Voucher"
        },
        new GetVoucherListDto
        {
            VoucherNumber = 3,
            Name = "Myntra",
            Description = "Myntra 50 Rupees Discount"
        },
        new GetVoucherListDto
        {
            VoucherNumber = 4,
            Name = "Swiggy",
            Description = "Swiggy 200 Rupees Off"
        }
    };

            return Task.FromResult(vouchers);
        }
    }
}
