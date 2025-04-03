using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vou.Application.Contracts;
using Vou.Domain.Entities;

namespace Vou.Application.Features.Voucher.Commands.CreateVoucher
{
    public class CreateVoucherCommandHandler : IRequestHandler<CreateVoucherCommand,int>
    {
        public IVoucherRepository _voucherRepository{ get; set; }
        public IMapper _mapper { get; set; }

        public CreateVoucherCommandHandler(IVoucherRepository voucherRepository,IMapper mapper)
        {
            _voucherRepository = voucherRepository;
            _mapper = mapper;
        }

        async Task<int> IRequestHandler<CreateVoucherCommand,int>.Handle(CreateVoucherCommand request, CancellationToken cancellationToken)
        {
            var voucher = _mapper.Map<Vou.Domain.Entities.Voucher>(request);
            var result = await _voucherRepository.CreateVoucher(voucher);
            return result;
        }
    }
}
