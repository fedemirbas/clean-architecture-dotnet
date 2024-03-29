﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities
{
    public class Account : AuditableBaseEntity
    {
        public string AccountName { get; set; }
        public decimal Balance { get; set; }
        public string Currency { get; set; }
        public Guid CustomerId { get; set; }
    }
}
