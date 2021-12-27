using BlazorApp_WASM.Dtos;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Encodings;


namespace BlazorApp_WASM.Services
{
    public class GraphQLtrehabilitados : ITresHabilitados
    {
        private HttpClient _httpClient;

        public GraphQLtrehabilitados(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<LaunchDto[]> GetAllTresHabilitados()
        {
            var queryObj = new
            {
                query = @"{launches { id is_tentativ mission_name launch_date_local}}",
                variables = new { }

            };

            var launchesQuery = new StringContent(
                JsonSerializer.Serialize(queryObj), HeaderEncodingSelector<Utf8JsonReader>

                ,
                "application/json");

            var response = await _httpClient.PostAsync("graphql", launchQuery);

            if (response.IsSuccesStatusCode)
            {
               var gqlData = JsonSerializer.DeserializeAsync<GqlData>;
                (await response.Content.ReadAsStreamAsync());

                return gqlData.Data.Launches;            }

        }

        //public Task<LaunchDto[]> GetAllTresHabilitados()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
