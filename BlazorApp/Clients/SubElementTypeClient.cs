using BlazorApp.Cache.Abstraction;
using BlazorApp.Clients.Abstraction;
using BlazorApp.DataTransferContract.DataTransferObjects.Order;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.Clients
{
    public class SubElementTypeClient : ISubElementTypeClient
    {
        private readonly HttpClient _httpClient;
        private readonly ICacheManager _cacheManager;

        public SubElementTypeClient(
            HttpClient httpClient,
            ICacheManager cacheManager)
        {
            _httpClient = httpClient;
            _cacheManager = cacheManager;
        }
        public async Task<IEnumerable<SubElementTypeDto>> GetSubElementTypesAsync(CancellationToken cancellationToken = default)
        {
            var cachedItems = _cacheManager.GetSubElementTypes();

            if (!cachedItems.Any())
            {
                var items = await _httpClient.GetFromJsonAsync<SubElementTypeDto[]>("api/subElementTypes", cancellationToken);
                _cacheManager.CacheSubElementTypes(cachedItems);
                cachedItems = items;
            }

            return cachedItems;
        }
    }
}
