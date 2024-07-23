namespace ListasSimplementeLigadasCirculares
{
    internal class Nodo
    {
        public string Dato { get; set; }
        public Nodo? Enlace { get; set; }

        public Nodo(string dato = "", Nodo? enlace = null)
        {
            Dato = dato;
            Enlace = enlace;
        }
    }
}
