using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Vou.Application.Contracts;

namespace Vou.Application.Features.Voucher.Queries.GetVoucherList
{
    public class GetVoucherListQueryHandler : IRequestHandler<GetVoucherListQuery,List<GetVoucherListDto>>
    {
        private readonly IVoucherRepository _voucherRepository;
        private readonly IMapper _mapper;

        public GetVoucherListQueryHandler(IVoucherRepository voucherRepository,IMapper mapper)
        {
            _voucherRepository = voucherRepository;
            this._mapper = mapper;
        }
         async Task<List<GetVoucherListDto>> IRequestHandler<GetVoucherListQuery, List<GetVoucherListDto>>.Handle(GetVoucherListQuery request, CancellationToken cancellationToken)
        {
            var voucher = await _voucherRepository.GetVoucherList();
            var response = _mapper.Map<List<GetVoucherListDto>>(voucher);
            return response;
        }
    }
}
