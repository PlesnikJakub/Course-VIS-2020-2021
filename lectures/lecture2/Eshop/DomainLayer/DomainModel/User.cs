using System;

namespace DomainLayer.DomainModel
{
    public class User
    {
        public Guid Guid { get; set; }

        public string Name { get; set; }

        public double DiscountRate { get; internal set; }
    }
}