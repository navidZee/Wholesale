using System;
using System.Collections.Generic;
using System.Text;

namespace Wholesale.Domain.Common.Base
{
    public interface IEntity
    {
    }

    public abstract class BaseEntity<TKey> : IEntity
    {
        public TKey Id { get; set; }
    }

    public abstract class BaseEntity : BaseEntity<Guid>
    {
    }
}
