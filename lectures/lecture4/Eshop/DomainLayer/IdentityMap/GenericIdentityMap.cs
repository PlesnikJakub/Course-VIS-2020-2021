using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.IdentityMap
{
    public class GenericIdentityMap<T> where T : IEntity
    {
        private Dictionary<int, T> _entities = new Dictionary<int, T>();

        public T Get(int id)
        {
            if (_entities.ContainsKey(id))
            {
                return _entities[id];
            }
            return default(T);
        }

        public void Add(T istance)
        {
            _entities.Add(istance.Id, istance);
        }
    }
}
