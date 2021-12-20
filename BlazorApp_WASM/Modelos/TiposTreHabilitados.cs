namespace BlazorApp_WASM.Modelos
{
    
    public class TreHabilitado
    {
        public int CodigoTipoTre { get; set; }
        public string? Descripcion { get; set; }
        public bool Habilitado { get; set; }
    
    }
    
    public class TiposTreHabilitados
    {
        public List<TreHabilitado>? treHabilitados { get; set; } 
    }
}
