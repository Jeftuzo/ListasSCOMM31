using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Agregar(string dato)
        {
            Nodo nodoActual = _nodoInicial;
            while (nodoActual.Enlace != null)
            {
                nodoActual = nodoActual.Enlace;
            }
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.Dato = dato;

            nodoActual.Enlace = nuevoNodo;
        }
    }
}
