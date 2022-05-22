using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountTask.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
    }
}
