using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CustomerDebtSystem
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Records { get; set; }
        public DbSet<Total> Totals { get; set; }
    }
}
