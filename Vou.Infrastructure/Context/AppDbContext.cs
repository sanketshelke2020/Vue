using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vou.Domain.Entities;

namespace Vou.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<Voucher> Vouchers { get; set; }
    }
}
