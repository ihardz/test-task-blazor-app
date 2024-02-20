using BlazorApp.Cache.Abstraction;
using BlazorApp.DataTransferContract.DataTransferObjects.Order;
using BlazorApp.DataTransferContract.DataTransferObjects.State;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace BlazorApp.Cache
{
    public class CacheManager : ICacheManager
    {
        private readonly ConcurrentDictionary<int, StateDto> _states = new();
        private readonly ConcurrentDictionary<int, SubElementTypeDto> _subElementTypes = new();

        public IEnumerable<StateDto> GetStates() => _states.Values;
        public IEnumerable<SubElementTypeDto> GetSubElementTypes() => _subElementTypes.Values;

        public void CacheStates(IEnumerable<StateDto> items)
        {
            foreach (var item in items)
            {
                var key = item.Id;
                _states.TryAdd(key, item);
            }
        }

        public void CacheSubElementTypes(IEnumerable<SubElementTypeDto> items)
        {
            foreach (var item in items)
            {
                var key = item.Id;
                _subElementTypes.TryAdd(key, item);
            }
        }
    }
}
