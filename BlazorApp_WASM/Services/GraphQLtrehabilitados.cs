using BlazorApp_WASM.Dtos;

namespace BlazorApp_WASM.Services
{
    public class GraphQLtrehabilitados : ITresHabilitados
    {
        private HttpClient _httpClient;

        public GraphQLtrehabilitados(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<LaunchDto[]> GetAllTresHabilitados()
        {
            var queryObj = new
            {
                query = @"",
                variables = new { }

            };
        }

        //public Task<LaunchDto[]> GetAllTresHabilitados()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
