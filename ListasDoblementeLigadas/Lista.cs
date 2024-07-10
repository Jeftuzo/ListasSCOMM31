namespace ListasDoblementeLigadas
{
    internal class Lista
    {
        Nodo _nodoInicial;
        public Lista()
        {
            _nodoInicial = new Nodo();
        }

        private bool EstaVacio()
        {
            if (_nodoInicial.Siguiente == null) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Vaciar()
        {
            _nodoInicial.Siguiente = null;
        }

        public void Agregar(string dato)
        {
            Nodo nodoActual = _nodoInicial;
            while (nodoActual.Siguiente != null) 
            { 
                nodoActual = nodoActual.Siguiente;
            }

            Nodo nodoNuevo = new Nodo();
            nodoNuevo.Anterior = nodoActual;
            nodoNuevo.Dato = dato;

            nodoActual.Siguiente = nodoNuevo;
        }
    }
}
