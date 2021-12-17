using System.Text.Json.Serialization;

namespace BlazorApp_WASM.Dtos
{
    public partial class LaunchDto
    {
        [JsonPropertyName("codigo_tipo_")]
        //[JsonConverter(typeof(JsonConverter<string>))]
        public int codigoTipoTre { get; set; }

        [JsonPropertyName("descripcion")]
        public string? descripcion { get; set; }

        [JsonPropertyName("habilitado")]
        public bool habilitado { get; set; }
    }
}
