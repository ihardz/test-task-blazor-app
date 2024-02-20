using BlazorApp.DataTransferContract.DataTransferObjects.Order;
using BlazorApp.DataTransferContract.DataTransferObjects.State;
using System.Collections.Generic;

namespace BlazorApp.Cache.Abstraction
{
    public interface ICacheManager
    {
        IEnumerable<StateDto> GetStates();
        void CacheStates(IEnumerable<StateDto> items);
        IEnumerable<SubElementTypeDto> GetSubElementTypes();
        void CacheSubElementTypes(IEnumerable<SubElementTypeDto> items);
    }
}
