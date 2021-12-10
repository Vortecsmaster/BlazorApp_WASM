namespace BlazorApp_WASM.Modelos
{
    
    public class Tre_Habilitado
    {
        public int codigo_tipo_tre { get; set; }
        public string? descripcion { get; set; }
        public bool habilitado { get; set; }
    
    }
    
    public class Tipos_Tre_Habilitados
    {
        public List<Tre_Habilitado>? tre_habilitados { get; set; } 
    }
}
