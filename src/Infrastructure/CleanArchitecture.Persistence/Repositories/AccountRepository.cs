using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Application.Interfaces.Repositories;
using CleanArchitecture.Persistence.Contexts;

namespace CleanArchitecture.Persistence.Repositories
{
    public class AccountRepository : GenericRepository<Domain.Entities.Account>, IAccountRepository
    {
        public AccountRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
