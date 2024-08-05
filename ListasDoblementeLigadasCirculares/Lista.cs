using System.Text;

namespace ListasDoblementeLigadasCirculares
{
    internal class Lista
    {
        Nodo _nodoInicial;
        public Lista()
        {
            _nodoInicial = new Nodo();
            _nodoInicial.Anterior = _nodoInicial;
            _nodoInicial.Siguiente = _nodoInicial;
        }

        //Metodo para validar si la lista esta vacia
        private bool EstaVacio() => _nodoInicial.Siguiente == _nodoInicial;


        //Mertodo para vaciar la lista
        public void Vaciar()
        {
            _nodoInicial.Siguiente = _nodoInicial;
            _nodoInicial.Anterior = _nodoInicial;
        }

        //Metodo de para agregar nodos
        public void Agregar(string dato)
        {
            Nodo nodoActual = _nodoInicial;
            while (nodoActual.Siguiente != _nodoInicial)
            {
                nodoActual = nodoActual.Siguiente;
            }

            Nodo? nodoNuevo = new Nodo(anterior: nodoActual, dato: dato, siguiente: nodoActual.Siguiente);

            nodoActual.Siguiente = nodoNuevo;
            _nodoInicial.Anterior = nodoNuevo;
        }

        //metodo de busqueda de nodos
        public Nodo Buscar(string dato)
        {
            if (EstaVacio() == false)
            {
                Nodo nodoActual = _nodoInicial;
                while (nodoActual.Siguiente != _nodoInicial)
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
                Nodo nodoActual = Buscar(dato);
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

        //Metodo para obtener los datos de la lista
        public string ObtenerDatos()
        {
            StringBuilder datos = new StringBuilder();
            Nodo nodoActual = _nodoInicial;

            //nos vamos a posicionar siempre y cuando el nodo actual tenga un nodo enlazado diferente a _nodoInicial
            while (nodoActual.Siguiente != _nodoInicial)
            {
                nodoActual = nodoActual.Siguiente;
                datos.AppendLine(nodoActual.Dato);
            }
            return datos.ToString();
        }

        //Metodo para obtener los datos de la lista en sentido contrario
        public string ObtenerDatosReversa()
        {
            Nodo nodoActual = _nodoInicial;

            //metodo para saltar entre nodos
            while (nodoActual.Siguiente != _nodoInicial)
            {
                nodoActual = nodoActual.Anterior;
            }

            //contructor de strings de manera mas eficiente
            //https://learn.microsoft.com/es-es/dotnet/standard/base-types/stringbuilder
            StringBuilder datos = new StringBuilder();

            while (nodoActual.Anterior.Siguiente != _nodoInicial)
            {
                datos.AppendLine(nodoActual.Dato);
                nodoActual = nodoActual.Anterior;
            }
            return datos.ToString();
        }
    }
}
