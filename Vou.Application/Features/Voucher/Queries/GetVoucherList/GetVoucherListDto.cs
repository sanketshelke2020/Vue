using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vou.Application.Features.Voucher.Queries.GetVoucherList
{
    public class GetVoucherListDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int VoucherNumber { get; set; }
    }
}
