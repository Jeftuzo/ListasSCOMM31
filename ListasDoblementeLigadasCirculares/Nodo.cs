namespace ListasDoblementeLigadasCirculares
{
    internal class Nodo
    {
        public Nodo? Anterior { get; set; } = null;
        public string Dato { get; set; } = string.Empty;
        public Nodo? Siguiente { get; set; } = null;

        public Nodo(Nodo anterior = null!,string dato = "",Nodo siguiente = null!)
        {
            Anterior = anterior;
            Dato = dato;
            Siguiente = siguiente;
        }
    }
}
