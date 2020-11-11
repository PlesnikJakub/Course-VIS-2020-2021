using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public interface IMap<T>
    {
        Dictionary<int, T> map { get; set; }

        T Get(int id);

        void Add(T item);
    }
}
