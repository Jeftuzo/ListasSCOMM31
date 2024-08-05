namespace ListasDoblementeLigadasCirculares
{
    internal class Nodo
    {
        public Nodo? Anterior { get; set; }
        public string Dato { get; set; }
        public Nodo? Siguiente { get; set; }

        public Nodo(Nodo? anterior = null, string dato = "", Nodo? siguiente = null)
        {
            Anterior = anterior;
            Dato = dato;
            Siguiente = siguiente;
        }

    }
}
