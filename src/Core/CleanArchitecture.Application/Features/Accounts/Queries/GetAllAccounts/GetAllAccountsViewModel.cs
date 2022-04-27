using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Features.Accounts.Queries.GetAllAccounts
{
    public class GetAllAccountsViewModel
    {
        public Guid Id { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }
        public string Currency { get; set; }
    }
}
