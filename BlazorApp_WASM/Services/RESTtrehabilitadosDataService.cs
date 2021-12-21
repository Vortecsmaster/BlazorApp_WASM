using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorApp_WASM.Dtos;
using BlazorApp_WASM.Services;

namespace BlazorApp_WASM.Services
{
    public class RESTtrehabilitadosDataService : ITresHabilitados
    {
        private readonly HttpClient _httpClient;

        public RESTtrehabilitadosDataService(HttpClient httpClient)
        {
            _httpClient=httpClient;
        }   
        
        public async Task<LaunchDto[]> ITresHabilitados.GetAllTresHabilitados()
        {
            return await _httpClient.GetFromJsonAsync<LaunchDto[]>("sample-data/trehabilitados.json");
        }
    }
}

