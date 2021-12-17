using Microsoft.AspNetCore.Components;
using BlazorApp_WASM.Dtos

namespace BlazorApp_WASM.Pages
{
    public partial class FetchData
    {
        [Inject]
        private HttpClient Http { get; set; }
    }
}
