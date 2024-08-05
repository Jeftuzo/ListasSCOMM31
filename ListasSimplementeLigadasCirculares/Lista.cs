﻿using System.Text;

namespace ListasSimplementeLigadasCirculares
{
    internal class Lista
    {
        private Nodo _nodoInicial;

        /// <summary>
        /// Este es el constructor de la classe
        /// </summary>
        /// https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/xmldoc/recommended-tags#summary
        public Lista()
        {
            _nodoInicial = new Nodo(enlace: _nodoInicial);
        }

        //Metodo para validar si la lista esta vacia
        public bool EstaVacia()
        {
            return _nodoInicial.Enlace == _nodoInicial;
        }

        //Metodo para vaciar la lista
        public void Vaciar()
        {
            _nodoInicial.Enlace = _nodoInicial;
        }
        //Este metodo me sirve para agregar elementos a mi coleccion
        //voy a recivir el dato a agregar en el parametro "dato"
        public void Agregar(string dato)
        {
            //declaramos un este objeto para posicionarnos 
            Nodo nodoActual = _nodoInicial;

            //nos vamos a posicionar siempre y cuando el nodo actual tenga un nodo enlazado 
            while (nodoActual!.Enlace != _nodoInicial)
            {
                nodoActual = nodoActual!.Enlace!;
            }

            //declaramos un nuevo objeto y le asignamos el dato 
            Nodo nuevoNodo = new Nodo(dato: dato, enlace: _nodoInicial);


            //agregamos el nuevo nodo al final de la coleccion
            nodoActual.Enlace = nuevoNodo;
        }

        //nos vamos a posicionar siempre y cuando el nodo actual tenga un nodo enlazado 
        public string ObtenerDatos()
        {
            StringBuilder datos = new StringBuilder();
            Nodo nodoActual = _nodoInicial;

            //nos vamos a posicionar siempre y cuando el nodo actual tenga un nodo enlazado 
            while (nodoActual.Enlace != _nodoInicial)
            {
                nodoActual = nodoActual!.Enlace!;
                datos.AppendLine(nodoActual.Dato);
            }
            return datos.ToString();
        }

        //Metodo para buscar un dato en la lista
        public Nodo? Buscar(string dato)
        {
            //el signo ! esta negando el valor 
            //ejemplo: si EstaVacia es verdadero se cambia a falso 
            if (!EstaVacia())
            {
                Nodo nodoActual = _nodoInicial;

                while (nodoActual.Enlace != _nodoInicial)
                {
                    nodoActual = nodoActual!.Enlace!;
                    if (nodoActual.Dato == dato)
                    {
                        return nodoActual;
                    }
                }
            }
            return null;
        }

        //Metodo para buscar el dato anterir al que buscamos
        public Nodo? BuscarAnterior(string dato)
        {
            if (!EstaVacia())
            {
                Nodo nodoActual = _nodoInicial;

                while (nodoActual.Enlace != _nodoInicial)
                {
                    if (nodoActual!.Enlace!.Dato == dato)
                    {
                        return nodoActual;
                    }
                    nodoActual = nodoActual.Enlace;
                }
            }
            return null;
        }

        //Metodo para eliminar un dato de la lista
        public void EliminarNodo(string dato)
        {
            if (EstaVacia() == false)
            {
                Nodo? nodoActual = Buscar(dato);

                if (nodoActual != null)
                {
                    Nodo? nodoAnterior = BuscarAnterior(dato)
                        ?? throw new Exception("No se encontro nodo anterior");

                    nodoAnterior.Enlace = nodoActual.Enlace;
                    nodoActual.Enlace = null;

                }
            }
        }
    }
}
