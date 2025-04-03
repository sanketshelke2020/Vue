using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vou.Domain.Entities;

namespace Vou.Application.Contracts
{
    public interface IVoucherRepository
    {
        public Task<List<Voucher>> GetVoucherList();
        public Task<int> CreateVoucher(Voucher voucher);
    }
}
