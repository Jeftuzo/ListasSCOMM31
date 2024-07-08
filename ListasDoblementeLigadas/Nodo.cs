namespace ListasDoblementeLigadas
{
    internal class Nodo
    {
        public Nodo? Anterior { get; set; } = null;
        public string Dato { get; set; } = string.Empty;
        public Nodo? Siguiente { get; set; } = null;
    }
}
