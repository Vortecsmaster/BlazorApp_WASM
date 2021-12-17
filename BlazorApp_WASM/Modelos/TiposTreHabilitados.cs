namespace BlazorApp_WASM.Modelos
{
    
    public class TreHabilitado
    {
        public int codigo_tipo_tre { get; set; }
        public string? descripcion { get; set; }
        public bool habilitado { get; set; }
    
    }
    
    public class TiposTreHabilitados
    {
        public List<TreHabilitado>? treHabilitados { get; set; } 
    }
}
