using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vou.Application.Contracts;
using Vou.Application.Features.Voucher.Queries.GetVoucherList;
using Vou.Domain.Entities;
using Vou.Infrastructure.Context;

namespace Vou.Infrastructure.Repository
{
    public class VoucherRepository : IVoucherRepository
    {
        private AppDbContext _dbContext { get; set; }
        public VoucherRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public VoucherRepository()
        {
            
        }
        public async Task<List<Voucher>> GetVoucherList()
        {
    //        var vouchers = new List<Voucher>
    //{
    //    new Voucher
    //    {
    //        VoucherNumber = 1,
    //        Name = "Flipkart",
    //        Description = "Flipkart 100 Rupees Voucher"
    //    },
    //    new Voucher
    //    {
    //        VoucherNumber = 2,
    //        Name = "Amazon",
    //        Description = "Amazon 100 Rupees Voucher"
    //    },
    //    new Voucher
    //    {
    //        VoucherNumber = 3,
    //        Name = "Myntra",
    //        Description = "Myntra 50 Rupees Discount"
    //    },
    //    new Voucher
    //    {
    //        VoucherNumber = 4,
    //        Name = "Swiggy",
    //        Description = "Swiggy 200 Rupees Off"
    //    }
    //};
            return await _dbContext.Vouchers.ToListAsync();
        }

        public async Task<int> CreateVoucher(Voucher voucher)
        {
            _dbContext.Vouchers.AddAsync(voucher);
            return _dbContext.SaveChanges();
        }
    }
}
