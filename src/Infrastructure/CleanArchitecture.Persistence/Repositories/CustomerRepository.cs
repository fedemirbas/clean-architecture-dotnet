using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.Interfaces.Repositories;
using CleanArchitecture.Persistence.Contexts;

namespace CleanArchitecture.Persistence.Repositories
{
    public class CustomerRepository : GenericRepository<Domain.Entities.Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
