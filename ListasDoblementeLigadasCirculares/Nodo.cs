namespace ListasDoblementeLigadasCirculares
{
    internal class Nodo(Nodo? anterior = null, string dato = "", Nodo? siguiente = null)
    {
        public Nodo? Anterior { get; set; } = anterior;
        public string Dato { get; set; } = dato;
        public Nodo? Siguiente { get; set; } = siguiente;

    }
}
