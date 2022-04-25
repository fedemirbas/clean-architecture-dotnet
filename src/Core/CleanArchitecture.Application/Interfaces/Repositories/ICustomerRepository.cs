using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Interfaces.Repositories
{
    public interface ICustomerRepository : IGenericRepository<Domain.Entities.Customer>
    {
    }
}
