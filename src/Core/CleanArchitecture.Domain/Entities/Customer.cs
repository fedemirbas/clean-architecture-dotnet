﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities
{
    public class Customer : AuditableBaseEntity
    {
        public string CustomerFullName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }
    }
}
