using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vou.Application.Features.Voucher.Commands.CreateVoucher;
using Vou.Application.Features.Voucher.Queries.GetVoucherList;
using Vou.Domain.Entities;

namespace Vou.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Voucher,CreateVoucherCommand>().ReverseMap();
            CreateMap<Voucher,GetVoucherListDto>();
            CreateMap<GetVoucherListDto, Voucher>().ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
