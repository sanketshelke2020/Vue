using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vou.Domain.Entities;

namespace Vou.Application.Features.Voucher.Queries.GetVoucherList
{
    public class GetVoucherListQuery : IRequest<List<GetVoucherListDto>>
    {

    }
}
