namespace BlazorApp_WASM.Modelos
{
    public class Reciprocidad
    {
        public int codigo_tipo_tre { get; set; }
        public int id_emcori { get; set; }
    }

    public class MatrizReciprocidad
    {
        public List<Reciprocidad>? matriz { get; set; }
    }
}
