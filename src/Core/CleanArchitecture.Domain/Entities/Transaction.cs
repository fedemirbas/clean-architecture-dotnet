using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities
{
    public class Transaction : BaseEntity
    {
        public decimal Amount { get; set; }
        public DateTime ActionDate { get; set; }
        public int ActionType { get; set; }
        public Guid AccountId { get; set; }
        public Guid ActionAccountId { get; set; }
    }
}
