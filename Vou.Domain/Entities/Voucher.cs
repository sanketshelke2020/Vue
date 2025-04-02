using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vou.Domain.Entities
{
    public class Voucher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int VoucherNumber { get; set; }
    }
}
