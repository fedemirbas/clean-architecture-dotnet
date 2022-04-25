using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Common
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }
    }
}
