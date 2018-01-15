using System;

namespace CSharpDomain.Model
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
    }
}
