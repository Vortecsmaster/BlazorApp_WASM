using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorApp_WASM.Dtos;
using BlazorApp_WASM.Services;
using Microsoft.AspNetCore.Components;


namespace BlazorApp_WASM.Pages
{
    public partial class FetchData
    {
        private LaunchDto[]? dataFromDto;

        [Inject]
        ITresHabilitados tresHabilitados { get; set; }

        //private HttpClient Http { get; set; }


        protected override async Task OnInitializedAsync()
        {
            dataFromDto = tresHabilitados.GetAllTresHabilitados().Result;

            //dataFromDto = await Http.GetFromJsonAsync<LaunchDto[]>("sample-data/trehabilitados.json");
        }
    }
}
