using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced
{
    public class Cache <TKey, TValue> 
    {
        private Dictionary<TKey, TValue> _cache = new Dictionary<TKey, TValue>();

        // Add
        public void Add(TKey key, TValue value)
        {
            _cache[key] = value;
        }

        // Get
        public TValue Get(TKey key)
        {
            if (_cache.TryGetValue(key, out var value))
            {
                return value;
            }

            return default;
        }

        // Contains
        public bool Contains(TKey key)
        {
            return _cache.ContainsKey(key);
        }

        // Remove
        public bool Remove(TKey key)
        {
            return _cache.Remove(key);
        }


    }
}
