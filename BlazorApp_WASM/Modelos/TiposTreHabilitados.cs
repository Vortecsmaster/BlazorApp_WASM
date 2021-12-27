using System.Text.Json.Serialization;

namespace BlazorApp_WASM.Modelos
{
    
    public class TreHabilitado
    {
        [JsonPropertyName("codigo_tipo_tre")]
        public int CodigoTipoTre { get; set; }

        [JsonPropertyName("descripcion")]
        public string? Descripcion { get; set; }

        [JsonPropertyName("habilitado")]
        public bool Habilitado { get; set; }
    
    }
    
    public class TiposTreHabilitados
    {
        [JsonPropertyName("tre_habilitados")]
        public List<TreHabilitado>? treHabilitados { get; set; } 
    }
}
