using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Interfaces.Repositories
{
    public interface IAccountRepository : IGenericRepository<Domain.Entities.Account>
    {
    }
}
