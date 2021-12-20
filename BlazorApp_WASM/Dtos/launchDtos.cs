using System.Text.Json.Serialization;

namespace BlazorApp_WASM.Dtos
{
    public partial class LaunchDto
    {
        [JsonPropertyName("codigo_tipo_tre")]
        //[JsonConverter(typeof(JsonConverter<string>))]
        public int codigoTipoTre { get; set; }

        [JsonPropertyName("descripcion")]
        public string? descripcion { get; set; }

        [JsonPropertyName("habilitado")]
        public int habilitado { get; set; }
    }
}
