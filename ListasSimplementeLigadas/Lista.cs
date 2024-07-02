using System.Text;

namespace ListasSimplementeLigadas
{
    internal class Lista
    {
        private Nodo _nodoInicial;
        public Lista()
        {
            _nodoInicial = new Nodo();
        }

        public bool EstaVacia()
        {
            //if (_nodoInicial.Enlace == null)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return _nodoInicial.Enlace == null;
        }

        public void Vaciar()
        {
            _nodoInicial.Enlace = null;
        }
        //Este metodo me sirve para agregar elementos a mi coleccion
        //voy a recivir el dato a agregar en el parametro "dato"
        public void Agregar(string dato)
        {
            //declaramos un este objeto para posicionarnos 
            Nodo nodoActual = _nodoInicial;

            //nos vamos a posicionar siempre y cuando el nodo actual tenga un nodo enlazado 
            while (nodoActual.Enlace != null)
            {
                nodoActual = nodoActual.Enlace;
            }

            //declaramos un nuevo objeto y le asignamos el dato 
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.Dato = dato;

            //agregamos el nuevo nodo al final de la coleccion
            nodoActual.Enlace = nuevoNodo;
        }

        public string ObtenerDatos()
        {
            StringBuilder datos = new StringBuilder();
            Nodo nodoActual = _nodoInicial;

            //nos vamos a posicionar siempre y cuando el nodo actual tenga un nodo enlazado 
            while (nodoActual.Enlace != null)
            {
                nodoActual = nodoActual.Enlace;
                datos.AppendLine(nodoActual.Dato);
            }
            return datos.ToString();
        }

        public Nodo? Buscar(string dato)
        {
            //el signo ! esta negando el valor 
            //ejemplo: si EstaVacia es verdadero se cambia a falso 
            if (!EstaVacia())
            {
                Nodo nodoActual = _nodoInicial;

                while (nodoActual.Enlace != null)
                {
                    nodoActual = nodoActual.Enlace;
                    if (nodoActual.Dato == dato)
                    {
                        return nodoActual;
                    }
                }
            }
            return null;
        }
        public Nodo? BuscarAnterior(string dato)
        {
            if (!EstaVacia())
            {
                Nodo nodoActual = _nodoInicial;

                while (nodoActual.Enlace != null)
                {
                    if (nodoActual.Enlace.Dato == dato) 
                    {
                        return nodoActual;
                    }
                    nodoActual = nodoActual.Enlace;
                }
            }
            return null;
        }
    }
}
