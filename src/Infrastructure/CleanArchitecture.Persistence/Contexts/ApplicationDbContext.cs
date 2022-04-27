using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Domain.Entities.Customer> Customers { get; set; }
        public DbSet<Domain.Entities.Account> Accounts { get; set; }
        public DbSet<Domain.Entities.Transaction> Transactions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
