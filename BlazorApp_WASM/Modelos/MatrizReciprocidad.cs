namespace BlazorApp_WASM.Modelos
{
    public class Reciprocidad
    {
        public int CodigoTipoTre { get; set; }
        public int IdEmcori { get; set; }
    }

    public class MatrizReciprocidad
    {
        public List<Reciprocidad>? Matriz { get; set; }
    }
}
