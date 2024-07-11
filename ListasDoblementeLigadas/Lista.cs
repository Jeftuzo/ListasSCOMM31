namespace ListasDoblementeLigadas
{
    internal class Lista
    {
        Nodo _nodoInicial;
        public Lista()
        {
            _nodoInicial = new Nodo();
        }
        //Metodo para validar si la lista esta vacia
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
        //Mertodo para vaciar la lista
        public void Vaciar()
        {
            _nodoInicial.Siguiente = null;
        }
        //Metodo de para agregar nodos
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
        //metodo de busqueda de nodos
        public Nodo? Buscar(string dato)
        {
            if (EstaVacio() == false)
            {
                Nodo nodoActual = _nodoInicial;
                while (nodoActual.Siguiente != null)
                {
                    nodoActual = nodoActual.Siguiente;
                    if (nodoActual.Dato == dato)
                    {
                        return nodoActual;
                    }
                }
            }
            return null;
        }
        //Metodo para eliminar nodos
        public void Eliminar(string dato)
        {
            if (EstaVacio() == false)
            {
                Nodo? nodoActual = Buscar(dato);
                //metodo para navegar en las propiedades de los nodos
                if (nodoActual != null)
                {
                    //Reubicando los enlaces
                    nodoActual.Anterior!.Siguiente = nodoActual.Siguiente;
                    nodoActual.Siguiente!.Anterior = nodoActual.Anterior;

                    //opcionalmente eliminamos los enlaces del nodo a eliminar
                    nodoActual.Anterior = null;
                    nodoActual.Siguiente = null;
                }
            }
        }
    }
}
