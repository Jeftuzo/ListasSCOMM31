namespace ListasSimplementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("F***k Lunes");
            Lista miLista = new Lista();
            miLista.Agregar("A");
            miLista.Agregar("B");
            miLista.Agregar("C");

            Console.WriteLine(miLista.ObtenerDatos());

            Console.WriteLine("Buscando B");
            Nodo? nodoB = new Nodo();
            nodoB = miLista.Buscar("B");
            if (nodoB != null )
            {
                Console.WriteLine(nodoB.Dato);
            }
            else
            {
                Console.WriteLine("No encontrado");
            }
            Console.WriteLine("Buscando el anterior");
            Nodo? nodoC = new Nodo();
            nodoC = miLista.BuscarAnterior("A");
            if (nodoC != null )
            {
                Console.WriteLine(nodoC.Dato);
            }
            else
            {
                Console.WriteLine("No encontrado");
            }
        }
    }
}
