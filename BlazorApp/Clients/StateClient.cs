using BlazorApp.Cache.Abstraction;
using BlazorApp.Clients.Abstraction;
using BlazorApp.DataTransferContract.DataTransferObjects.State;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class StateClient: IStateClient
    {
        private readonly HttpClient _httpClient;
        private readonly ICacheManager _cacheManager;

        public StateClient(
            HttpClient httpClient,
            ICacheManager cacheManager)
        {
            _httpClient = httpClient;
            _cacheManager = cacheManager;
        }

        public async Task<IEnumerable<StateDto>> GetStatesAsync(CancellationToken cancellationToken = default) 
        {
            var cachedStates = _cacheManager.GetStates();

            if (!cachedStates.Any()) {
                var states = await _httpClient.GetFromJsonAsync<StateDto[]>("api/states", cancellationToken);
                _cacheManager.CacheStates(states);
                cachedStates = states;
            }
            
            return cachedStates;
        }
    }
}
