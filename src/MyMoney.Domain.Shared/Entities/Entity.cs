using System;

namespace MyMoney.Domain.Shared.Entities
{
    public class Entity
    {
        public Guid Id { get; private set; }

        public override bool Equals(object obj)
        {
            return obj is Entity entity &&
                   Id.Equals(entity.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}