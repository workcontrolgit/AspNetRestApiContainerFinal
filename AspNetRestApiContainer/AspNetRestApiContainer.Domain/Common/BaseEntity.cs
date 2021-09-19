using System;

namespace AspNetRestApiContainer.Domain.Common
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }
    }
}