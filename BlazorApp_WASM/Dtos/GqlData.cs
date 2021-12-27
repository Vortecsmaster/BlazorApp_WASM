using BlazorApp_WASM.Modelos;
using BlazorApp_WASM.Dtos;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlazorApp_WASM.Dtos
{
    public partial class GqlData
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonPropertyName("tipos_tre_habilitados")]
        public TiposTreHabilitados TresHabilitados { get; set; }
    }

}
