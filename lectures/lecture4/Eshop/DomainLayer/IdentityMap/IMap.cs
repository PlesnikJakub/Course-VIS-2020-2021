using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.IdentityMap
{
    public interface IMap<T>
    {
        Dictionary<int, T> map { get; set; }

        T Get(int id);

        void Add(T item);
    }
}
